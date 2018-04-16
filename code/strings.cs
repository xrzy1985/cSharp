using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp_tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            // strings

            /*  \'  Single qoute
             *  \"  Double qoute
             *  \\  Back slash
             *  \b  backwards one space
             *  \n  new line
             *  \t  tab
             */

            // create a string with random words
            string str = "A bunch of random words";

            // To find out if the string is null or empty
            Console.WriteLine("Is Null/Empty: " + String.IsNullOrEmpty(str));

            // to find out if the string is null or just white space
            Console.WriteLine("Is Null/WhiteSpace: " + String.IsNullOrWhiteSpace(str));

            // to find the str length
            Console.WriteLine("String Length: " + str.Length);

            // to find a specific word in a string of words/chars
            Console.WriteLine("Index of bunch: " + str.IndexOf("bunch"));

            // to find a specific word, and you know the word; such as of
            // we find the starting position and go from there
            Console.WriteLine("3rd word: " + str.Substring(8, 2));

            // here we will combined the str.indexof with substring
            Console.WriteLine("4th word: " + str.Substring(str.IndexOf("random"), 6));

            // create another string to use
            string str2 = "More random words will appear here";
            string str3 = str2;

            // To see if the two strings are equal to each other
            Console.WriteLine("String equality: " + str.Equals(str2));

            // To see if the two strings are equal to each other
            Console.WriteLine("String equality2: " + str2.Equals(str3));

            // Here we will check str to see if it starts with "A bunch"
            Console.WriteLine("Starts with \"A bunch\" " + str.StartsWith("A bunch"));

            // here we are checking if str2 ends with here
            Console.WriteLine("Ends with here " + str2.EndsWith("here"));

            // To trim a string
            // str.Trim()   str.TrimEnd()   str.TrimStart()

            string st = "  Hello World  ";

            // here we will see trim
            st = st.Trim();
            Console.WriteLine(st);

            // This is how you would replace a word in a string
            // Replace(wordToReplace, wordToReplaceWith)
            str = str.Replace("words", "characters");

            Console.WriteLine(str);

            // Lets create a new string to hold a random phrase
            string phrase = "Of all the places I could live, I choose Georgia.";

            // this is how you would remove a part of that string
            // Remove(startingIndex, endingIndex)
            phrase = phrase.Remove(0, 3);

            Console.WriteLine(phrase);

            // Here we are creating a string array called names
            // we set the array with 3 indexes
            string[] names = new string[3] { "James", "Earl", "Patterson" };

            // This will print the names in the array with a , inbetween the names
            Console.WriteLine("Names in array: " + String.Join(", ", names));

            // This will format the string the way you would like it to be
            // more on c# string formatting at
            String formatStr = String.Format("{0:c}{1:00.00}{2:#.00}{3:0,0}", 1.56, 15.567, .56, 1000);

            Console.WriteLine(formatStr);

            // let's create a double to hold a price
            double price = 17.36;

            // this string will format with a $17.36
            String ss = String.Format("The current price is {0:c} per ounce.", price);

            Console.WriteLine(ss);

            // This will pop the DateTime.Now (right now), and push 20.5 for the degrees
            string sss = String.Format("At {0}, the temperature is {1}°C.", DateTime.Now, 20.5);

            Console.WriteLine(sss);

            // Let us create an array to hold some years
            int[] years = { 2013, 2014, 2015 };

            // Lets create an array to hold some made up populations
            int[] population = { 1025632, 1105967, 1148203 };

            // The string ssss will format the year with 6 spaces; right aligned
            // and the population with 15 spaces; right aligned
            String ssss = String.Format("{0,6} {1,15}\n\n", "Year", "Population");

            // for loop to loop through the arrays
            for (int index = 0; index < years.Length; index++)
            {
                // Format a string with the year right aligned with 6 spaces
                // a 2nd column right aligned with 15 spaces formatted as a number with 0 decimal places
                ssss += String.Format("{0,6} {1,15:N0}\n", years[index], population[index]);
            }

            /*  For more information on creating custom numeric formatted strings visit
             *  https://docs.microsoft.com/en-us/dotnet/standard/base-types/custom-numeric-format-strings             *
             */

            Console.WriteLine("\nPress any key to close...");
            Console.ReadKey();

        }
    }
}

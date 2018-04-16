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
            // Lists

            // List<dataType> name = new List<dataType>()
            List<int> numberList = new List<int>();

            // it is super easy to add a value onto the end of a list
            numberList.Add(1);  numberList.Add(12); numberList.Add(123);

            // Let us loop through the numberList and print the values
            foreach(int num in numberList)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("\n");

            // You can add an array to a list
            int[] array = { 1, 23, 456, 7890, 12345 };

            // This will add the array onto the end of the numberList
            numberList.AddRange(array);

            // Let us loop through the numberList and print the values
            foreach (int num in numberList)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("\n");

            // You can clear the list by using the following code
            // numberList.Clear();

            // You can create a List with an array inside of it
            List<int> numberList2 = new List<int>(array);

            // Let us loop through the numberList and print the values
            foreach (int num in numberList2)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("\n");

            // You can define the array inside of the List initialization
            // Not too sure why you would need to do this, but you can
            List<int> numberList3 = new List<int>(new int[]{ 0, 12, 345, 6789 });

            // Here we will insert 01 at the 1st index
            numberList3.Insert(1, 0);

            // here we will remove 1
            numberList2.Remove(1);

            // here we will remove the value at the 3rd index
            numberList.RemoveAt(2 );

            // list.Count is how you find the length of your LIST
            for(int i = 0; i < numberList.Count; i++)
            {
                Console.Write(numberList[i] + " ");
            }

            Console.WriteLine("\n");

            // We can find the index of a specific number inside our list
            Console.WriteLine("23 is in index " + numberList.IndexOf(23));

            // We can check to see if a list contains a number
            Console.WriteLine("456 is in List: " + numberList.Contains(456));

            //
            Console.WriteLine("4 is in List: " + numberList.Contains(4));

            // Let's see how strings work with Lists in C#
            List<string> strList = new List<string>(new string[] { "James", "Earl", "Patterson" });

            // the StringComparer at the end of this statement might throw you off
            // that is just taking the lower case earl and matching it with Earl
            // if you wanted to set it up normally, you could easily
            Console.WriteLine("Is Earl in the list: " + strList.Contains("earl", StringComparer.OrdinalIgnoreCase));

            // right here; it will return true because Earl is in the list
            Console.WriteLine("Is Earl in the list: " + strList.Contains("Earl"));

            // but EARL wont be
            Console.WriteLine("Is EARL in the list: " + strList.Contains("EARL"));

            // We can sort the List
            strList.Sort();

            // The list will now be looped, you will notice that the strings are in alphabetical order
            foreach(string word in strList)
            {
                Console.WriteLine(word);
            }

            Console.WriteLine("\nPress any key to close...");
            Console.ReadKey();

        }
    }
}

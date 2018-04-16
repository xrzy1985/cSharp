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
            // Arrays

            // declaring an array without any values
            int[] randomArray;

            // declaring an array with 5 values
            int[] numArray = new int[5];

            // declaring an array with 5 values
            int[] numbers = { 1, 5, 3, 4, 2 };

            // we can easily find the length of an Array
            Console.WriteLine("numArray Length: " + numArray.Length);

            Console.WriteLine("numbers Length: " + numbers.Length);

            // here we will loop through the numbers array
            for(int i = 0; i < numbers.Length; i++)
            {
                // output to console -> index : value
                Console.WriteLine("{0} : {1}", i, numbers[i]);
            }

            // we could use the foreach loop as well
            foreach(int num in numArray)
            {
                // remember that we did not give numArray any values
                // So, the output will be 0, 0, 0, 0, 0,
                Console.Write("{0}, ", num);
            }

            // To see that the code above really does work
            // the following code will print the values in the numbers array
            // right after the code above -> Output: 0, 0, 0, 0, 0, 1, 2, 3, 4, 5,
            foreach (int num in numbers)
            {
                Console.Write("{0}, ", num);
            }

            // Array.IndexOf(nameOfArray, valueYouAreSearchingFor)
            Console.WriteLine("Number 2 is located in index: " + Array.IndexOf(numbers, 2));

            // Here we create an array called names, with 3 values; 3 names
            string[] names = { "James", "Earl", "Patterson" };

            // we will use string.join to join the names with 1 spot of white space between each one
            // you could use , | \ . any delimiter you wish to use
            string nameString = string.Join(",", names);

            Console.WriteLine(nameString);

            // this is creating a new array named nameArray
            // Split is used to separate the names in nameString
            // to be stored inside of our nameArray
            string[] nameArray = nameString.Split(',');

            // printing out the nameArray will result in names without ,
            foreach(string str in nameArray)
            {
                Console.WriteLine(str);
            }

            // To initialize multidimensional arrays within C#
            // dataType[,] name = new dataType[x, y];
            int[,] multiArray = new int[5, 3];

            // dataTYpe[,] name = { {x1, y1}, {x2, y2}, {x3. y3} };
            int[,] multiArray2 = { { 0, 1 }, { 2, 3 }, { 4, 5 } };

            // This will loop through the array from left to right
            foreach(int i in multiArray2)
            {
                Console.WriteLine(i);
            }

            //
            for (int i = 0; i < multiArray2.GetLength(0); i++)
            {
                for(int j = 0; j < multiArray2.GetLength(1); j++)
                {
                    // i | j | value in array at [i, j]
                    Console.WriteLine("x{0} | y{1} : {2}", i, j, multiArray2[i, j]);
                }
            }

            Console.WriteLine("\nPress any key to close...");
            Console.ReadKey();

        }
    }
}

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
            // For_each loop

            // here will define a string called randomString
            string randomString = "Here are some random characters";

            // the for each loop will loop through once for every
            // item we declare it to
            // (dataType variable in OutsideVariable)


            // here we will loop through the string one char at a time
            // and print out each individual char (white space is a char too)
            // until the end of the randomString has been reached
            foreach(char c in randomString)
            {
                Console.Write(c);
            }

            Console.WriteLine("\n");

            // here we will loop through the string one char at a time again, but
            // we will print each char on their own line
            foreach (char d in randomString)
            {
                Console.WriteLine(d);
            }


            Console.WriteLine("\nPress any key to close...");
            Console.ReadKey();

        }
    }
}

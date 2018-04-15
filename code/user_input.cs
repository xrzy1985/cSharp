using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *  Comments can be multilined comments
 */
 // or single lined comments

namespace cSharp_tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            // We will output the question to the user through the console
            Console.Write("Enter your name: ");

            // this is C# gets user input
            // here we just create a string variable to hold the value entered
            // ReadLine will accept any kind of data entered, but it will treat it as a string
            // you will need to cast it as a different data type if you need it to be
            string name = Console.ReadLine();

            // We will print out to the console Hello + theirName
            Console.WriteLine("Hello " + name);

            Console.WriteLine("Press any key to close...");
            Console.ReadKey();

        }
    }
}

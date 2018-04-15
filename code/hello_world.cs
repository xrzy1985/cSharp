using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *  Comments can be multilined comments
 */
 // or single lined comments

 // I'm going to be learning C# as I go along with these tutorials
 // I already understand how to program, but learning a new language
 // can be a little tricky.

namespace cSharp_tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write will output to the same line
            Console.Write("Hello ");
            // while WriteLine will add a endline at the end of the code
            // it is like print and println in java
            Console.WriteLine("World");

            // The following lines will ensure that the console application
            // does not close automatically once execution is finished
            Console.WriteLine("Press any key to close");
            Console.ReadKey();

        }
    }
}

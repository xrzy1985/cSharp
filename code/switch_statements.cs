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
            // define an int variable with value 16
            int age = 16;

            // define our goto area
            // when you jump out of a switch statement to something like this
            // the switch statement will repeat again, you could get stuck in a infinite loop
            // try setting the age to 2, and see what happens
            // C# will read line by line from top to bottom, and the goto keeps the compiler looping from
            // the cute: to the switch statement back to cute; causing an infinite loop
            cute:
                Console.WriteLine("Toddlers happen to be cute.\n");

            // a switch statement will find the appropriate statement to match up with age
            // break statements break out of the switch statement and start the reading the file at the
            // end of the statement again.
            switch (age)
            {
                // if the age = 0
                case 0:
                    age = 0;
                    Console.WriteLine("Infant\n");
                    break;
                // age is 1
                case 1:
                    age = 1;
                    break;
                // age is 2; infinite loop
                case 2:
                    age = 2;
                    Console.WriteLine("Toddler\n");
                    goto cute;
                // the default statement
                default:
                    Console.WriteLine("Kid\n");
                    break;
            }

            Console.WriteLine("This will execute after the switch statement no matter what.\n");


            Console.WriteLine("\nPress any key to close...");
            Console.ReadKey();

        }
    }
}

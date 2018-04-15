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
            // For Loops

            // the for loop has three individual segments
            // (incremental/decremental variable; condition for variable, ++/-- variable)
            // the loop will execute until i = 9
            for (int i = 0; i < 10; i++)
            {
                // here, we will only print out the odd numbers
                // Even % 2 = 0; Odd % 2 = value
                if((i % 2) > 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("\n");

            // The outer loop will execute once for every full execution of the 2nd loop
            for(int j = 1; j <= 10; j++)
            {
                // this will loop 1-5 then kick out to the outer loop
                for(int k = 1; k <= 5; k++)
                {
                    Console.WriteLine(k);
                }

                Console.WriteLine("\n");
                Console.WriteLine(j);
            }


            Console.WriteLine("\nPress any key to close...");
            Console.ReadKey();

        }
    }
}

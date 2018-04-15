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
            int i = 0;

            while(i < 10)
            {
                if(i == 7)
                {
                    i++;
                    // continue will jump back up to the top of the loop when executed
                    continue;
                }

                if(i == 9)
                {
                    // break will kick execution out of the loop and continue on after the loop code
                    break;
                }

                // this will only give us the remainders of odd numbers
                // the modulus of any even number will result in a 0
                // So the program will run from 0 to 9
                // the console will not output any even numbers
                // only 1 3 5 then 7 continues and 9 breaks out
                if ( (i%2) > 0 )
                {
                    Console.WriteLine(i);
                }

                i++;

            }


            Console.WriteLine("\nPress any key to close...");
            Console.ReadKey();

        }
    }
}

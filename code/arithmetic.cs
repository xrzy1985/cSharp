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

            Console.WriteLine("5 + 3 = " + (5 + 3) + "\n");
            Console.WriteLine("5 - 3 = " + (5 - 3) + "\n");
            Console.WriteLine("5 * 3 = " + (5 * 3) + "\n");
            Console.WriteLine("5 / 3 = " + (5 / 3) + "\n");
            Console.WriteLine("5.2 % 3 = " + (5.2 % 3) + "\n");

            int i = 0;

            // i is set to 0
            // i++ will increase i to 1, but it does so after the line of code is completely executed
            Console.WriteLine("i++ = " + (i++) + "\n");
            // meaning the ++i here will result in i = 2
            Console.WriteLine("++i = " + (++i) + "\n");
            // i will stil equal 2 because we decrement after the execution
            Console.WriteLine("i-- = " + (i--) + "\n");
            // finally i will result in a 0 again
            Console.WriteLine("--i = " + (--i) + "\n");

            Console.WriteLine("i += 3 = " + (i += 3) + "\n");
            Console.WriteLine("i -= 2 = " + (i -= 2) + "\n");
            Console.WriteLine("i *= 2 = " + (i *= 2) + "\n");
            Console.WriteLine("i /= 2 = " + (i /= 2) + "\n");
            Console.WriteLine("i %= 2 = " + (i %= 2) + "\n");

            Console.WriteLine("\nPress any key to close...");
            Console.ReadKey();

        }
    }
}

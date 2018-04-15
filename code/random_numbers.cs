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
            // How to get a random number from C#
            Random ranNum = new Random();

            Console.WriteLine("A Random number between 1 and 10 " + (ranNum.Next(1, 11)) + "\n");

            Console.WriteLine("A Random number between 1 and 100 " + (ranNum.Next(1, 101)) + "\n");

            Console.WriteLine("A Random number between 1 and 1000 " + (ranNum.Next(1, 1001)) + "\n");

            Console.WriteLine("A Random number between 1 and 10000 " + (ranNum.Next(1, 10001)) + "\n");

            Console.WriteLine("\nPress any key to close...");
            Console.ReadKey();

        }
    }
}

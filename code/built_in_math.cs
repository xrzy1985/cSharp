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
            // casting will automatically, but if it is not

            double pi = 3.1415;
            int intPi = (int)pi;

            Console.WriteLine(intPi);

            /* Some more Math functions built into C# are
             * Acos
             * Asin
             * Atan
             * Atan2
             * Cos
             * Cosh
             * Exp
             * Sin
             * Sinh
             * tan
             * tanh
             */

            //
            double num1 = 10.5;
            double num2 = 15;

            Console.WriteLine("Math.Abs(number 1) " + (Math.Abs(num1)) + "\n");
            Console.WriteLine("Math.Ceiling(number 1) " + (Math.Ceiling(num1)) + "\n");
            Console.WriteLine("Math.Floor(number 1) " + (Math.Floor(num1)) + "\n");
            Console.WriteLine("Math.Max(number 1) " + (Math.Max(num1, num2)) + "\n");
            Console.WriteLine("Math.Min(number 1) " + (Math.Min(num1, num2)) + "\n");
            Console.WriteLine("Math.Pow(number 1) " + (Math.Pow(num1, num2)) + "\n");
            Console.WriteLine("Math.Round(number 1) " + (Math.Round(num1)) + "\n");
            Console.WriteLine("Math.Sqrt(number 1) " + (Math.Sqrt(num1)) + "\n");



            Console.WriteLine("\nPress any key to close...");
            Console.ReadKey();

        }
    }
}

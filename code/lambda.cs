/*
Lambda expressions use the token => in an expression context.
  In this context, the token is not a comparison operator.
Goes to:
  The => operator can be read as "goes to." It is always used
  when declaring a lambda expression.
Invoke:
With Invoke, a method on Func and Action, we execute the methods in the lambdas.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp_tutorial
{
    class CSharp
    {
        static void Main(string[] args)
        {
            // lambda Expressions

            // Are essentially a way to pass an equation as a parameter

            List<int> numbersList = new List<int> { 10, 20, 31, 40, 55, 76 };

            // ... Find index of first odd element.
            int oddIndex = numbersList.FindIndex(x => x % 2 != 0);

            Console.WriteLine(oddIndex);

            // Create a Func
            // Here we have to be careful to get the right number of parameters
            // You have two variables x and y, and you'll return a value of x+y
            // so that is why it is <int, int, int>
            // <x, y, return(x*y)>
            Func<int, int, int> getSum = (x, y) => x + y;

            Console.WriteLine("5 + 3 = " + getSum.Invoke(5, 3));

            // Lets use the numbersList again to store the odd numbers in a list of their own
            List<int> oddNumbers = numbersList.Where(n => n % 2 == 1).ToList();

            // loop through the List to print out the numbers inside of oddNumbers
            foreach(int num in oddNumbers)
            {
                Console.WriteLine("{0} ", num);
            }

            // create some more variables
            int a = 3; double b = 0.1; double c = 0.04;

            //
            Func<int, double, double, double> piSum = (x, y, z) => x + y + z;

            //
            Console.WriteLine(piSum.Invoke(a, b, c));

            Console.WriteLine("\nPress any key to close...");
            Console.ReadKey();

        //END of Main
        }
    // END of cSharp
    }
//END of namespace std
}

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
            // Use a Do While loop instead of while loops
            // when you are definitely going through the code
            // in the loop at least once BEFORE you check if you
            // should continue to cycle through the loop

            // Basically, you will do the code inside the loop
            // until the conditional statement you write in the while
            // block is reached.

            // We will have the user guess a number until they guess 15
            string guess;

            do
            {
                // we will output "Guess a number"
                Console.WriteLine("Guess a number: ");
                // guess will be assigned to the entered value by the user
                guess = Console.ReadLine();
            }
            // do the above code while the guess does not equal 15
            while (!guess.Equals("15"));

            Console.WriteLine("You chose correctly!");


            Console.WriteLine("\nPress any key to close...");
            Console.ReadKey();

        }
    }
}

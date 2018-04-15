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
            // Conditionals
            // >  Greater than
            // <  Less Than
            // >= Greater than or equal to
            // <= Less than or equal to
            // == Equal to
            // != Not equal to

            // Logical
            // &&
            // ||
            // ^
            // !

            // we create a random number
            Random num = new Random();

            // we have to initialize the number as an int variable
            int number = num.Next(1, 11);

            // Run through an if statement
            // if the number is less than 5
            if ( number <= 5 )
            {
                Console.WriteLine("The number is between 1-5.\n");
            }
            // if the number is between 6-9
            else if(number >= 6 && number <= 9)
            {
                Console.WriteLine("The number is between 6-9.\n");
            }
            // if the number is equal to 10
            else
            {
                Console.WriteLine("The number is 10.\n");
            }


            Console.WriteLine("\nPress any key to close...");
            Console.ReadKey();

        }
    }
}

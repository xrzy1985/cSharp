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

            int age = 17;

            if ( (age >=5) && (age <= 10))
            {
                Console.WriteLine("You belong in Elementary School.\n");
            }
            else if( (age >= 11) && (age <= 13) )
            {
                Console.WriteLine("You belong in Middle School.\n");
            }
            else
            {
                Console.WriteLine("You belong in High School.\n");
            }


            // if we want to check if a person can legally work in the United States
            if ( (age <= 14) || (age >= 67) )
            {
                Console.WriteLine("You are not legally eligiable to work in the United States.\n");
            }
            else
            {
                Console.WriteLine("You are eligible to work in the United States.\n");
            }

            // Here we will look at the !
            Console.WriteLine("Not True " + (!true) + "\n");

            // create a bool variable with the value true
            bool a = true;
            // write out to console the !a, which will return false since a is set to true
            Console.WriteLine("a is not " + (!a) + "\n");

            // this is asking if age is greater than 16 or not
            // if so, return true and set value true to canDrive
            // if not , canDrive will be set to false
            bool canDrive = age >= 16 ? true : false;

            Console.WriteLine("It is " + canDrive + " that you can drive.\n");


            Console.WriteLine("\nPress any key to close...");
            Console.ReadKey();

        }
    }
}

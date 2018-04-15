using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *  Comments can be multilined comments
 */
 // or single lined comments

namespace cSharp_tutorial
{
    class Program
    {
        static void Main(string[] args)
        {

            // Data types
            bool canVote = true;

            // char
            char grade = 'A';

            // int - max: 2,147,483,647
            int maxInt = int.MaxValue;

            // long - max: 9,223,372,036,854,775,807
            long maxLong = long.MaxValue;

           // decimal - max: 79,228,162,514,264,337,593,543,950,335
            // if you need a larger number, look up BigInteger
            decimal maxDec = decimal.MaxValue;

            // float - max: 3.402823E+28
            // float will have 7 decimals of precision
            float maxFloat = float.MaxValue;

            // double - max: 1.797693134E+308
            // double will hav 15 decimals of precision
            double maxDouble = double.MaxValue;

            // Now let us print all of these out to console 
            Console.WriteLine("\n" + canVote + "\n");

            Console.WriteLine(grade + "\n");

            Console.WriteLine(maxInt + "\n");

            Console.WriteLine(maxLong + "\n");

            Console.WriteLine(maxDec + "\n");

            Console.WriteLine(maxFloat + "\n");

            Console.WriteLine(maxDouble + "\n");


            // var variable types can be changed after initialization, but they cannot be changed to a
            // different data type then they already are.
            var firstName = "James";
            var age = 32;
            // the following line of code is illegal
            // firstName = 1;
            // the following code is acceptable though
            firstName = "Jim";

            Console.Write("My name is " + firstName + " and I am " + age + " years old.\n");

            // we can get the data type of a var as well
            Console.Write("\nfirstName is a {0}\n", firstName.GetTypeCode());

            Console.Write("\nage is a {0}\n", age.GetTypeCode());

            Console.WriteLine("\nPress any key to close...");
            Console.ReadKey();

        }
    }
}

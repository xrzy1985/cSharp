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
            // Error Handling

            /*
             *  System.IO.IOException -
             *          Handles I/O errors.
             *  System.IndexOutOfRangeException
             *          Handles errors generated when a method refers to an array index out of range.
             *  System.ArrayTypeMismatchException
             *          Handles errors generated when type is mismatched with the array type.
             *  System.NullReferenceException
             *          Handles errors generated from referencing a null object.
             *  System.DivideByZeroException
             *          Handles errors generated from dividing a dividend with zero.
             *  System.InvalidCastException
             *          Handles errors generated during typecasting.
             *  System.OutOfMemoryException
             *          Handles errors generated from insufficient free memory.
             *System.StackOverflowException
             *          Handles errors generated from stack overflow.
             */

            try
            {
                Console.Write("Divide 10 by ");

                int num = int.Parse(Console.ReadLine());

                Console.WriteLine("10 / {0} = {1}", num, (10/num));
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("You Cannot Divide By Zero");
                Console.WriteLine(e.GetType().Name);
                Console.WriteLine(e.Message);

                throw new InvalidOperationException("Operation has Failed", e);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.GetType().Name);
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("\nPress any key to close...");
            Console.ReadKey();

        }
    }
}

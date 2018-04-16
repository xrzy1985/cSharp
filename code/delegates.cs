using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// define the delegates outside of the namespace
delegate double GetSum(double number1, double number2);

namespace cSharp_tutorial
{
    class CSharp
    {
        static void Main(string[] args)
        {
            // Delegates

            // Anonomous Methods
            // have no name and the return type is defined strictly by the
            // return type used within the method implicitly

            // MethodName name = delegate(dataType name, dataType name2...)
            GetSum sum = delegate (double number1, double number2)
            {
                return number1 + number2;
            };

            Console.WriteLine("5 plus 10 = " + sum(5, 10));

            Console.WriteLine("\nPress any key to close...");
            Console.ReadKey();

        //END of Main
        }
    // END of cSharp
    }
//END of namespace std
}

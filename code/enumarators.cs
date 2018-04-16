using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp_tutorial
{
    class CSharp
    {
        public enum Temp
        {
            Freeze,     // 0
            Low,        // 1
            Warm,       // 2
            Boil        // 3
        }

        static void Main(string[] args)
        {
            // Enumarators
            // are unique types that will have symbolic names and associated values

            // Define the enum
            Temp microwaveTemp = Temp.Low;

            switch(microwaveTemp)
            {
                case Temp.Freeze:
                    Console.WriteLine("Temperature is on Freezing.\n");
                    break;

                case Temp.Low:
                    Console.WriteLine("Temperature is on Low.\n");
                    break;

                case Temp.Warm:
                    Console.WriteLine("Temperature is on Warm.\n");
                    break;

                case Temp.Boil:
                    Console.WriteLine("Temperature is on Boiling.\n");
                    break;

            //END of switch
            }



            Console.WriteLine("\nPress any key to close...");
            Console.ReadKey();

        //END of Main
        }
    // END of cSharp
    }
//END of namespace std
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Life
{
    class Life
    {
        public virtual void StartVehicle(GenericVehicle v) { }
        public virtual void Drive(GenericVehicle v) { }

        static void Main(string[] args)
        {
            GenericVehicle Sheilah = new Car(true, true, "7\" Double Din DVD Player", 21.5, "10w30", 2000, "Ford", "Mustang", "00000000", 6, "3.8 Liter", 4, true, 4, true, "James Patterson", false);

            // Console.WriteLine(Sheilah.PrintVehicleInformation());

            Life james = new Person();
                    
            james.StartVehicle(Sheilah);

            james.Drive(Sheilah);

            Console.WriteLine("\nPress any key...");
            Console.ReadKey();

        }
    }

}



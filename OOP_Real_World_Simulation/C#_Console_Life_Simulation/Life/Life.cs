using System;
using System.Reflection;

namespace Life
{
    class Life : Life_Functions
    {
        static void Main(string[] args)
        { 
            GenericVehicle Sheilah = new Car(true, true, "7\" Double Din DVD Player", 21.5, "10w30", 2000, "Ford", "Mustang", "00000000", 6, "3.8 Liter", 4, true, 4, true, "James Patterson", false);

            GenericVehicle Dodge = new Truck(true, true, "Single Din Cd Player", 25.5, "10w40", 2, "Standard", 2000, "Dodge", "Ram", "00000000", 8, "4.8 Liter", 4, true, 2, true, "Jill Hardin", true, "Dodge");

            GenericVehicle Reba = new Motorcycle("No Stereo Installed", 45.5, "5w20", true, 2008, "Honda", "Shadow", "00000000", 2, "750 cc", 2, true, 2, false, "James Patterson", false, "Reba");
             
            Console.WriteLine(Sheilah.PrintVehicleInformation());

            Console.WriteLine(Dodge.PrintVehicleInformation());

            Console.WriteLine(Reba.PrintVehicleInformation());

            Life james = new Person("James", "Patterson", 32, 'M');

            /*
            Type reflect = james.GetType();

            Console.WriteLine("Reflection.MethodInfo");

            // Get Method Information.
            MethodInfo myMethodInfo = reflect.GetMethod("Drive");

            object[] mParam = new object[] { james, Sheilah };

            // Get and display the Invoke method.
            Console.Write("First method: " + reflect.FullName + " returns " + myMethodInfo.Invoke(james, mParam) + "\n");

            Console.WriteLine(reflect + "\n");
            */

            Food breakfast = new Food();

            james.Eat(james, breakfast);

            james.GetInVehicle(james, Sheilah);
                    
            james.StartVehicle(james, Sheilah);

            james.Drive(james, Sheilah);

            james.TurnOffVehicle(james, Sheilah);

            Console.WriteLine("\nPress any key...");
            Console.ReadKey();

        }
    }

}



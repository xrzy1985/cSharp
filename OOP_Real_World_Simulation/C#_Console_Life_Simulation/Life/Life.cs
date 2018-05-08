using System;
using System.Reflection;

namespace Life
{
    class Life : Life_Functions
    {
        private string _name;

        public string GetLifeName() { return _name; }
        public void SetLifeName(string n) => this._name = n;

        public Life()
        {
            this._name = "Unknown";
        }

        public Life(string n)
        {
            this._name = n;
        }

        ~Life() { System.Diagnostics.Trace.WriteLine("Life's destructor is called.\n"); } 

        static void Main(string[] args)
        { 
            GenericVehicle Sheilah = new Car(true, true, "7\" Double Din DVD Player", 21.5, "10w30", 2000, "Ford", "Mustang", "00000000", 6, "3.8 Liter", 4, true, 4, true, "James Patterson", false);

            GenericVehicle Dodge = new Truck(true, true, "Single Din Cd Player", 25.5, "10w40", 2, "Standard", 2000, "Dodge", "Ram", "00000000", 8, "4.8 Liter", 4, true, 2, true, "Jill Hardin", true, "Dodge");

            GenericVehicle Reba = new Motorcycle("No Stereo Installed", 45.5, "5w20", true, 2008, "Honda", "Shadow", "00000000", 2, "750 cc", 2, true, 2, false, "James Patterson", false, "Reba");

            Life marlowe = new Dog("Marlowe", 5, 16, 21.5);

            Life stray = new Cat("Stray Cat", 2, 13, 10.2);

            Life red = new Bird("Red", 2, 6, 2);

            Food food = new Food();

            food.SetFood("bacon");
            
            Life james = new Person("James", "Patterson", 32, 'M', false);
            
            james.WakeUp(james);

            marlowe.Bark(marlowe);

            stray.Meow(stray);

            red.Chirp(red);

            james.Eat(james, food);

            james.GetInVehicle(james, Sheilah);
                    
            james.StartVehicle(james, Sheilah);

            james.Drive(james, Sheilah);

            james.TurnOffVehicle(james, Sheilah);

            james.GoToSleep(james);

            Console.WriteLine("Press any key...");
            Console.ReadKey();

        }
    }

}



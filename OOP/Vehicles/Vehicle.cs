using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    class Vehicle : IVehicle
    {
        protected static int count = 0;

        protected int Year { get; set; }
        protected string Make { get; set; }
        protected string Model { get; set; }
        protected int NumberOfWheels { get; set; }

        protected bool VehicleOn { get; set; }
        protected bool VehicleParked { get; set; }
        protected bool VehicleDriving { get; set; }

        public Vehicle() { count++; }

        ~Vehicle() { }

        public Vehicle(int y, string m, string mo, int nw)
        {
            this.Year = y;
            this.Make = m;
            this.Model = mo;
            this.NumberOfWheels = nw;
            count += 1;
        }

        public virtual void GetInformation()
        {
            Console.WriteLine("Year: " + this.Year);
            Console.WriteLine("Make: " + this.Make);
            Console.WriteLine("Model: " + this.Model);
            Console.WriteLine("Wheels: " + this.NumberOfWheels);
        }

        public static void GetCount()
        {
            Console.WriteLine("Count: " + count + "\n");
        }

        static void Main(string[] args)
        {

            Vehicle a = new Vehicle { Year = 1994, Make = "Chevrolet", Model = "Camaro", NumberOfWheels = 4 };

            Vehicle b = new Vehicle(2004, "Ford", "Mustang", 4);

            Vehicle c = new Car(2017, "Ford", "Gt-50", 4, 2, 3.6, true);

            Vehicle d = new Truck(2000, "Dodge", "Ram", 4, false, "King", true);

            a.GetInformation();

            Console.WriteLine("\n");

            b.GetInformation();

            Console.WriteLine("\n");

            c.GetInformation();

            d.GetInformation();

            d.VehicleParked = true;

            TurnVehicleOn(d);

            d.VehicleParked = false;

            Drive(d);

            d.VehicleDriving = false;

            d.VehicleParked = true;

            TurnVehicleOff(d);

            GetCount();

            Console.WriteLine("\nPress any key to close...");
            Console.ReadKey();
        }

        public void EngagePark(Vehicle v)
        {
            if(v.VehicleParked == false)
            {
                if(v.VehicleDriving == false)
                {
                    v.VehicleParked = true;
                }
            }
        }

        public void DisengagePark(Vehicle v)
        {
            if(v.VehicleParked == true)
            {
                if(v.VehicleDriving == false)
                {
                    v.VehicleParked = false;
                }
            }
        }

        public static void TurnVehicleOn(Vehicle v)
        {
            if (v.VehicleOn == false)
            {
                if (v.VehicleParked == true)
                {
                    v.VehicleOn = true;
                    Console.WriteLine("Vehicle is on.\n");
                }
            }
        }

        public static void TurnVehicleOff(Vehicle v)
        {
            if (v.VehicleOn == true)
            {
                if (v.VehicleParked == true)
                {
                    v.VehicleOn = false;
                    Console.WriteLine("Vehicle is off.\n");
                }
            }
        }

        public static void Drive(Vehicle v)
        {
            if(v.VehicleOn == true)
            {
                if(v.VehicleParked == false)
                {
                    v.VehicleDriving = true;
                    Console.WriteLine("Vehicle is currently driving.\n");
                }
            }
        }
    }
}

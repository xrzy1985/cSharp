using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    internal class Car : Vehicle
    {
        public int NumberOfDoors { get; set; }
        public double EngineSize { get; set; }
        public bool PowerWindows { get; set; }

        public Car() : base() { }

        public Car(int y, string m, string mo, int nw, int nd, double e, bool pw) : base(y, m, mo, nw)
        {
            this.NumberOfDoors = nd;
            this.EngineSize = e;
            this.PowerWindows = pw;
        }

        public override void GetInformation()
        {
            base.GetInformation();

            Console.WriteLine("Number of Doors: " + this.NumberOfDoors);
            Console.WriteLine("Engine Size: " + this.EngineSize + " Litre Engine");
            Console.WriteLine("Power Windows: " + this.PowerWindows);
            Console.WriteLine("\n");
        }

    }
}

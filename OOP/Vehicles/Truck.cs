using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    internal class Truck : Vehicle
    {
        public bool FourWheelDrive { get; set; }
        public string CabSize { get; set; }
        public bool PowerWindows { get; set; }

        public Truck()
        {
        }                

        public Truck(int y, string m, string mo, int nw, bool fw, string c, bool pw) : base(y, m, mo, nw)
        {
            this.FourWheelDrive = fw;
            this.CabSize = c;
            this.PowerWindows = pw;
        }

        ~Truck() { }

        public override void GetInformation()
        {
            base.GetInformation();

            Console.WriteLine("Four Wheel Drive (4x4): " + this.NumberOfWheels);
            Console.WriteLine("Cab Size: " + this.CabSize);
            Console.WriteLine("Power Windows: " + this.PowerWindows);
            Console.WriteLine("\n");

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Life
{
    class Person : Life
    {
        public override void StartVehicle(GenericVehicle v)
        {
            v.TurnOnEngine();
        }

        public override void Drive(GenericVehicle v)
        {
            if (v.engine_running == true)
            {
                Console.WriteLine("You are driving, mate.");
            }
            else
            {
                Console.WriteLine("You cannot drive the vehicle without starting the vehicle.");
            }

        }
    }
}

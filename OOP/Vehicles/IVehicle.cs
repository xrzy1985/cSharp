using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    interface IVehicle
    {
        void EngagePark(Vehicle v);
        void DisengagePark(Vehicle v);
    }
}

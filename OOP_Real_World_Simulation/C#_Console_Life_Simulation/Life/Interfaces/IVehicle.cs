using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Life
{
    interface IVehicle
    {
        void TurnOnEngine(Object o, GenericVehicle v);
        void TurnOffEngine(Object o, GenericVehicle v);
        void Honk(GenericVehicle v);
        bool Is_Parked(GenericVehicle v);
    }
}

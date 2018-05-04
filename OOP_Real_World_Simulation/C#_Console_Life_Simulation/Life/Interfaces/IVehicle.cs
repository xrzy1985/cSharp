using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Life
{
    interface IVehicle
    {
        void TurnOnEngine();
        void TurnOffEngine();
        void Honk();
        bool Is_Parked();
    }
}

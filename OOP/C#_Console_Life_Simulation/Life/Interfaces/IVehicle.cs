using System;

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

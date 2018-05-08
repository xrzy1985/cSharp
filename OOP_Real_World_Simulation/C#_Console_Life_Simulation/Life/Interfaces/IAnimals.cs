using System;

namespace Life
{
    interface IAnimals
    {
        void Eat(Object o, Food f);
        void WakeUp(Object o);
        void GoToSleep(Object o);
    }
}

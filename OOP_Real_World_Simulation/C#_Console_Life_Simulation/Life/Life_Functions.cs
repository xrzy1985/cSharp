using System;

namespace Life
{
    abstract class Life_Functions
    {
        public static int count = 0;
        public virtual int GetCount() { return count; }
        public virtual void SetCount(int i) => Life.count = i;

        // LIFE FORMS
        public virtual void Eat(Object o, Food f) { Console.WriteLine("Does this life form eat?\n"); }
        public virtual void WakeUp(Object o) { Console.WriteLine("The life form has woken up.\n"); }
        public virtual void GoToSleep(Object o) { Console.WriteLine("This life form has gone to sleep.\n"); }

        // PERSON, and other objects since technically a Dog could get in a vehicle
        public virtual void GetInVehicle(Object o, GenericVehicle v)
        {
            if (o.GetType() == typeof(Person))
            {
                Console.WriteLine("This will never be used\n");
            }
            else if (o.GetType() == typeof(Life) || o.GetType() == typeof(Dog) || o.GetType() == typeof(Cat))
            {
                Console.WriteLine("You can get in the car, but you cannot drive.\n");
            }
            else
            {
                Console.WriteLine("You can get in the car, but I'm not too sure I want you to.\n");
            }
        }
        public virtual void StartVehicle(Object o, GenericVehicle v)
        {
            if (o.GetType() == typeof(Person))
            {
                v.TurnOnEngine(o, v);
            }
            else
            {
                Console.WriteLine("This life form cannot start a vehicle.\n");
            }
        }
        public virtual void TurnOffVehicle(Object o, GenericVehicle v)
        {
            if (o.GetType() != typeof(Person))
            {
                Console.WriteLine("This life form cannot drive a vehicle, none the less be able to turn off a vehicle.\n");
            }
        }
        public virtual void Drive(Object o, GenericVehicle v) { Console.WriteLine("This life form cannot drive a vehicle.\n"); }

        // Animals: Dogs, Cats, Birds, and more to come
        public virtual void Bark(object o) { Console.WriteLine("This life form cannot bark correctly.\n"); }
        public virtual void Meow(object o) { Console.WriteLine("This life form cannot meow correctly.\n"); }
        public virtual void Chirp(Object o) { Console.WriteLine("This life form cannot chirp corrently.\n"); }
    }
}

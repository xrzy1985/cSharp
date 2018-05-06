using System;

namespace Life
{
    class Person : Life
    {
        private string _fname;
        private string _lname;
        protected int age;
        protected char sex;
        // weight
        // height
        // nationality
        // disabilities
        // HP / Stamina / Etc

        // GETTERS and SETTERS
        public string GetName() { return _fname + " " + _lname; }
        public string GetFirstName() { return _fname; }
        public string GetLastName() { return _lname; }
        public void SetFirstName(string f) => this._fname = f;
        public void SetLastName(string l) => this._lname = l;
        public int GetAge() { return age; }
        public void SetAge(int a) => this.age = a;
        public char GetSex() { return sex; }
        public void SetSex(char s) => this.sex = s;

        // CONSTRUCTORS
        public Person() { }

        public Person(string _fn, string _ln, int a, char s)
        {
            this._fname = _fn;
            this._lname = _ln;
            this.age = a;
            this.sex = s;
        }        

        // EVERYDAY LIVING FUNCTIONS
        public override void Eat(object o, object f)
        {
            Console.WriteLine(this.GetFirstName() + " is eating food.\n");
        }
        
        // VEHICLE FUNCTIONS
        public override void GetInVehicle(Object o, GenericVehicle v)
        {
            Console.WriteLine("You get in the car.\n");
        }

        public override void StartVehicle(Object o, GenericVehicle v)
        {
            v.TurnOnEngine(o, v);
        }

        public override void TurnOffVehicle(Object o, GenericVehicle v)
        {
            v.TurnOffEngine(o, v);
        }

        public override void Drive(Object o, GenericVehicle v)
        {
            if (v.engine_running == true)
            {
                Console.WriteLine("You are now driving.\n");
            }
            else
            {
                Console.WriteLine("You cannot drive the vehicle without starting the vehicle.\n");
            }
        }
    }
}

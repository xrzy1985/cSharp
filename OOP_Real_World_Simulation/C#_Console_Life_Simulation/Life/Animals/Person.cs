using System;

namespace Life
{
    class Person : Life, IAnimals
    {
        private string _fname;
        private string _lname;
        protected int age;
        protected char sex;
        public bool awake;
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
        public bool GetAwakeStatus() { return awake; }
        public void SetAwakeStatus(bool awake) => this.awake = awake;

        // CONSTRUCTORS
        public Person() { this._fname = "First"; this._lname = "Last"; this.age = 0; this.sex = 'x'; this.awake = false; }

        public Person(string _fn, string _ln, int a, char s, bool awake)
        {
            this._fname = _fn;
            this._lname = _ln;
            this.age = a;
            this.sex = s;
            this.awake = awake;
        }

        // EVERYDAY LIVING FUNCTIONS
        public override void WakeUp(Object o)
        {
            this.SetAwakeStatus(true);
            Console.WriteLine(this.GetFirstName() + " has woken up.\n");
        }

        public override void GoToSleep(Object o)
        {
            this.SetAwakeStatus(false);
            Console.WriteLine(this.GetFirstName() + " has gone to sleep.\n");
        }

        public override void Eat(object o, Food f)
        {
            if (this.GetAwakeStatus() == true)
            {
                Console.WriteLine(this.GetFirstName() + " is eating " + f.GetFood() + ".\n");
            }
            else
            {
                Console.WriteLine(this.GetFirstName() + " needs to wake up first.\n");
            }
        }
        
        // VEHICLE FUNCTIONS
        public override void GetInVehicle(Object o, GenericVehicle v)
        {
            if(this.GetAwakeStatus() == true)
            {
                Console.WriteLine(this.GetFirstName() + " got in the car.\n");
            }
            else
            {
                Console.WriteLine(this.GetFirstName() + " needs to be awake first.\n");
            }
        }

        public override void StartVehicle(Object o, GenericVehicle v)
        {
            if (this.GetAwakeStatus() == true)
            {
                Console.WriteLine(this.GetFirstName() + " started the car.\n");
                v.TurnOnEngine(o, v);
            }
            else
            {
                Console.WriteLine(this.GetFirstName() + " needs to be awake first.\n");
            }            
        }

        public override void TurnOffVehicle(Object o, GenericVehicle v)
        {
            if (this.GetAwakeStatus() == true)
            {
                Console.WriteLine(this.GetFirstName() + " turned off the car.\n");
                v.TurnOffEngine(o, v);
            }
            else
            {
                Console.WriteLine(this.GetFirstName() + " needs to be awake first.\n");
            }            
        }

        public override void Drive(Object o, GenericVehicle v)
        {
            if (this.GetAwakeStatus() == true)
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
            else
            {
                Console.WriteLine(this.GetFirstName() + " needs to be awake first.\n");
            }
        }
    }
}

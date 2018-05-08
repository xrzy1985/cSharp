using System;
using System.Text;

namespace Life
{
    // Person inherits from Life and the interface, IAnimals
    class Person : Life, IAnimals
    {
        // VARIABLES
        private string _fname;
        private string _lname;
        protected new int age;
        protected char sex;
        public new bool awake;
        public double weight;
        protected string height;
        private string nationality;
        protected new int hp;
        protected new int attack;

        // GETTERS and SETTERS
        public override string GetName() { return _fname + " " + _lname; }
        public string GetFirstName() { return _fname; }
        public string GetLastName() { return _lname; }
        public void SetFirstName(string f) => this._fname = f;
        public void SetLastName(string l) => this._lname = l;
        public override int GetAge() { return age; }
        public override void SetAge(int a) => this.age = a;
        public char GetSex() { return sex; }
        public void SetSex(char s) => this.sex = s;
        public override bool GetAwakeStatus() { return awake; }
        public override void SetAwakeStatus(bool awake) => this.awake = awake;
        public override double GetWeight() { return this.weight; }
        public override void SetWeight(double w) => this.weight = w;
        public override string GetHeight() { return this.height; }
        public override void SetHeight(string h) => this.height = h;
        public string GetNationality() { return nationality; }
        public void SetNationality(string n) => this.nationality = n;
        public override int GetHP() { return hp; }
        public override void SetHP(int hp) => this.hp = hp;
        public override int GetAttack() { return attack; }
        public override void SetAttack(int atk) => this.hp = atk;

        // CONSTRUCTORS
        public Person()
        {
            this._fname = "First";
            this._lname = "Last";
            this.age = 0;
            this.sex = 'x';
            this.awake = false;
            this.weight = 0;
            this.height = "0\'0";
            this.nationality = "N/A";
            this.hp = 0;
            this.attack = 0;
        }

        public Person(string _fn, string _ln, int a, char s, bool awake, int w, string h, string n, int hp, int atk)
        {
            this._fname = _fn;
            this._lname = _ln;
            this.age = a;
            this.sex = s;
            this.awake = awake;
            this.weight = w;
            this.height = h;
            this.nationality = n;
            this.hp = hp;
            this.attack = atk;
        }

        public override void PrintInformation()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Person: {0} {1}\n" +
                "Age: {2}\n" +
                "Sex: {3}\n" +
                "Height: {6}\n" +
                "Weight: {5}\n" +
                "Nationality: {7}\n" +
                "HP: {8}" +
                "\n", this._fname, this._lname, this.age, this.sex, this.awake, this.weight, this.height, this.nationality, this.hp);

            Console.WriteLine(sb.ToString());
        }

        // DESTRUCTOR
        ~Person() { System.Diagnostics.Trace.WriteLine("Person's destructor is called.\n"); }

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

        public override void Fight(Life p1, Life p2)
        {
            int tempHP = 0;

            do
            {
                tempHP = p1.GetHP() - p2.GetAttack();

                p1.SetHP(tempHP);

                tempHP = p2.GetHP() - p1.GetAttack();

                p2.SetHP(tempHP);


            } while (p1.GetHP() <= 0 || p2.GetHP() <= 0);

            if (p1.GetHP() <= 0)
            {
                Console.WriteLine("Ohhhhhh! " + p1.GetName() + " is knocked out cold.\n");
            }
            else
            {
                Console.WriteLine("Ohhhhhh! " + p2.GetName() + " is knocked out cold.\n");
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

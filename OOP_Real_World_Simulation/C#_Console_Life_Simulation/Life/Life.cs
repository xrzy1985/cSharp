using System;
using System.Reflection;
using System.Text;

namespace Life
{
    class Life : Life_Functions
    {
        public string _name;
        public int age;
        private string height;
        private double weight;
        protected bool awake;
        protected int hp;
        protected int attack;

        public Life(){ this._name = "Unknown Life"; this.age = 0; this.height = "0\'0"; this.weight = 0; this.awake = false; this.hp = 0; this.attack = 0;
        }

        public Life(string n, int a, string h, double w, bool aw, int hp, int atk)
        {
            this._name = n;
            this.age = a;
            this.height = h;
            this.weight = w;
            this.awake = aw;
            this.hp = hp;
            this.attack = atk;
        }

        ~Life() { System.Diagnostics.Trace.WriteLine("Life's destructor is called.\n"); }

        public virtual string GetName() { return this._name; }
        public virtual void SetName(string s) => this._name = s;
        public virtual int GetAge() { return this.age; }
        public virtual void SetAge(int a) => this.age = a;
        public virtual string GetHeight() { return this.height; }
        public virtual void SetHeight(string h) => this.height = h;
        public virtual double GetWeight() { return this.weight; }
        public virtual void SetWeight(double d) => this.weight = d;
        public virtual bool GetAwakeStatus() { return awake; }
        public virtual void SetAwakeStatus(bool aw) => this.awake = aw;
        public virtual int GetHP() { return hp; }
        public virtual void SetHP(int hp) => this.hp = hp;
        public virtual int GetAttack() { return attack; }
        public virtual void SetAttack(int atk) => this.hp = atk;


        public virtual void PrintInformation()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Life Form: {0}" +
                "\n", this._name);
            Console.WriteLine(sb.ToString());
        }        

        static void Main(string[] args)
        { 
            GenericVehicle Sheilah = new Car(true, true, "7\" Double Din DVD Player", 21.5, "10w30", 2000, "Ford", "Mustang", "00000000", 6, "3.8 Liter", 4, true, 4, true, "James Patterson", false);

            GenericVehicle Dodge = new Truck(true, true, "Single Din Cd Player", 25.5, "10w40", 2, "Standard", 2000, "Dodge", "Ram", "00000000", 8, "4.8 Liter", 4, true, 2, true, "Jill Hardin", true, "Dodge");

            GenericVehicle Reba = new Motorcycle("No Stereo Installed", 45.5, "5w20", true, 2008, "Honda", "Shadow", "00000000", 2, "750 cc", 2, true, 2, false, "James Patterson", false, "Reba");

            Life marlowe = new Dog("Marlowe", 5, "1\'6", 21.5, false, 10);

            Life stray = new Cat("Stray Cat", 2, "1\'9", 10.2, false, 15);

            Life red = new Bird("Red", 2, "0\'7", 2, false, 5);

            Food food = new Food();

            food.SetFood("bacon");
            
            Life james = new Person("James", "Patterson", 32, 'M', false, 180, "5\'11", "American Indian", 100, 50);

            Life brian = new Person("Brian", "Anderson", 40, 'M', false, 125, "5\'11", "White", 100, 40);

            james.Fight(james, brian);

            james.PrintInformation();
            
            james.WakeUp(james);

            marlowe.Bark(marlowe);

            stray.Meow(stray);

            red.Chirp(red);

            james.Eat(james, food);

            james.GetInVehicle(james, Sheilah);
                    
            james.StartVehicle(james, Sheilah);

            james.Drive(james, Sheilah);

            james.TurnOffVehicle(james, Sheilah);

            james.GoToSleep(james);

            Console.WriteLine("Press any key...");

            Console.ReadKey();

        }
        
        
        
    }

}



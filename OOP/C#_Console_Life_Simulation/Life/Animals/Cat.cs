using System;

namespace Life
{
    class Cat : Life, IAnimals
    {
        public string name;
        public new int age;
        private string height;
        private double weight;
        protected new bool awake;
        protected new int attack;

        public Cat() { this.name = "Unknown cat"; this.age = 0; this.height = "0\'0"; this.weight = 0; this.awake = false; this.attack = 0; }

        ~Cat() { System.Diagnostics.Trace.WriteLine("Cat's destructor is called.\n"); }

        public Cat(string n, int a, string h, double w, bool aw, int atk)
        {
            this.name = n;
            this.age = a;
            this.height = h;
            this.weight = w;
            this.awake = aw;
            this.attack = atk;
        }

        public override string GetName() { return this.name; }
        public override void SetName(string s) => this.name = s;
        public override int GetAge() { return this.age; }
        public override void SetAge(int a) => this.age = a;
        public override string GetHeight() { return this.height; }
        public override void SetHeight(string h) => this.height = h;
        public override double GetWeight() { return this.weight; }
        public override void SetWeight(double d) => this.weight = d;
        public override bool GetAwakeStatus() { return awake; }
        public override void SetAwakeStatus(bool aw) => this.awake = aw;
        public override int GetHP() { return hp; }
        public override void SetHP(int hp) => this.hp = hp;
        public override int GetAttack() { return attack; }
        public override void SetAttack(int atk) => this.hp = atk;


        public override void Eat(object o, Food f)
        {
            Console.WriteLine(this.name + " is eating " + f.GetFood() + ".\n");
        }

        public override void WakeUp(Object o)
        {
            this.SetAwakeStatus(true);
            Console.WriteLine(this.GetName() + " has woken up.\n");
        }

        public override void GoToSleep(Object o)
        {
            this.SetAwakeStatus(false);
            Console.WriteLine(this.GetName() + " has gone to sleep.\n");
        }

        public override void Meow(object o) { Console.WriteLine(this.GetName() + " says, \"meow meow meow.\"\n"); }
    }
}

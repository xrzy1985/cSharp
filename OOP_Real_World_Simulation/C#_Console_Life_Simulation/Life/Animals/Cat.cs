using System;

namespace Life
{
    class Cat : Life, IAnimals
    {
        public string name;
        public int age;
        private int height;
        private double weight;

        public Cat() { this.name = "Unknown cat"; this.age = 0; this.height = 0; this.weight = 0; }

        ~Cat() { System.Diagnostics.Trace.WriteLine("Cat's destructor is called.\n"); }

        public Cat(string n, int a, int h, double w)
        {
            this.name = n;
            this.age = a;
            this.height = h;
            this.weight = w;
        }

        public string GetName() { return this.name; }
        public void SetName(string s) => this.name = s;
        public int GetAge() { return this.age; }
        public void SetAge(int a) => this.age = a;
        public int GetHeight() { return this.height; }
        public void SetHeight(int h) => this.height = h;
        public double GetWeight() { return this.weight; }
        public void SetWeight(double d) => this.weight = d;

        public override void Eat(object o, Food f)
        {
            Console.WriteLine(this.name + " is eating " + f.GetFood() + ".\n");
        }

        public override void Meow(object o) { Console.WriteLine(this.GetName() + " says, \"meow meow meow.\"\n"); }
    }
}

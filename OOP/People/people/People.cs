using System;

namespace People
{
    class People : PeopleFunctions, IPeople
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public People() { }

        ~People() { }

        public People(int i, string n, int a)
        {
            this.Id = i;
            this.Name = n;
            this.Age = a;
        }

        public override void PrintInformation()
        {
            Console.WriteLine("\nID: " + this.Id + "\nName: " + this.Name + "\nAge: " + this.Age);
        }        
    }
}

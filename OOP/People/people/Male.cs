using System;

namespace People
{
    class Male : People
    {
        protected char Sex { get; set; }

        public Male() { }

        public Male(int i, string n, int a, char s = 'M'): base(i, n, a)
        {
            this.Sex = s;
        }

        ~Male() { }

        public override void PrintInformation()
        {
            Console.WriteLine("\nID: " + this.Id + "\nName: " + this.Name + "\nAge: " + this.Age + "\nSex: " + this.Sex);
        }

    }
}

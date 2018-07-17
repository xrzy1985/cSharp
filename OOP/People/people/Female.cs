using System;

namespace People
{
    class Female : People
    {
        protected char Sex { get; set; }

        public Female() { }

        public Female(int i, string n, int a, char s = 'F') : base(i, n, a)
        {
            this.Sex = s;
        }

        ~Female() { }

        public override void PrintInformation()
        {
            Console.WriteLine("\nID: " + this.Id + "\nName: " + this.Name + "\nAge: " + this.Age + "\nSex: " + this.Sex);
        }
    }
}

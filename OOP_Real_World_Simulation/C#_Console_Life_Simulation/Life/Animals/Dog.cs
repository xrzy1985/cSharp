using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Life
{
    class Dog : Life
    {
        public override void Eat(object o, object f)
        {
            Console.WriteLine("The dog is eating food.\n");
        }
    }
}

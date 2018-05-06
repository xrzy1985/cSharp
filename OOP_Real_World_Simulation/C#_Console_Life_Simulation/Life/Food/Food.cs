using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Life
{
    class Food
    {
        public string food;

        public Food(string f)
        {
            this.food = f;
        }

        public Food(){ }

        public string GetFood(object f)
        {
            return this.food;
        }
    }
}

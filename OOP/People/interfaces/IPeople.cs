using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People
{
    interface IPeople
    {
        int Id { get; set; }
        string Name { get; set; }
        int Age { get; set; }

        void PrintInformation();
    }
}

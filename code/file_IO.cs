using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*

There are many ways to handle FILE IO within C#
This is just one easy way of doing it. I usually
add the easiest to the hardest on my files. So,
file_IO_1 will be easier than file_IO_5, but not
as easy as file_IO_3 will be. 

*/

namespace cSharp_tutorial
{
    class CSharp
    {
        static void Main(string[] args)
        {
            // File I/O

            // Lets create a string array
            string[] names = new string[] { "James", "Earl", "Patterson" };

            using (StreamWriter sw = new StreamWriter("names.txt"))
            {
                foreach(string n in names)
                {
                    sw.WriteLine(n);
                }
            }

            string name = "";

            using (StreamReader sr = new StreamReader("names.txt"))
            {
                while((name = sr.ReadLine()) != null)
                {
                    Console.WriteLine(name);
                }
            }

                Console.WriteLine("\nPress any key to close...");
            Console.ReadKey();

        //END of Main
        }
    // END of cSharp
    }
//END of namespace std
}

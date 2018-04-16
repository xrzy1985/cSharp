using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp_tutorial
{
    class CSharp
    {

        static void Main(string[] args)
        {
            //

            // This is a way of creating a generic object
            KeyValue<string, string> superman = new KeyValue<string, string>("", "");

            // Here we are defining the two strings
            superman.key = "Superman";
            superman.value = "Clark Kent";

            // The generic data types do not have to be the same at all
            KeyValue<int, string> acerLaptop = new KeyValue<int, string>(0, "")
            {
                // here we will define the attributes in a slightly different way
                key = 200012314,
                value = "Acer Aspire V5-5674"
            };

            superman.showData();

            Console.Write("Product No: ");

            acerLaptop.showData();


            Console.WriteLine("\nPress any key to close...");
            Console.ReadKey();

        //END of Main
        }

    // END of cSharp
    }

    // We can define generic classes with generic data types
    class KeyValue<TK, TV>
    {
        //
        public TK key { get; set; }
        public TV value { get; set; }

        //
        public KeyValue(TK k, TV v)
        {
            key = k;
            value = v;
        }

        //
        public void showData()
        {
            // this will display the data from the current object
            Console.WriteLine("{0} :|: {1} ", this.key, this.value + "\n");


            //END of showData
        }
        //END of KeyValue
    }
//END of namespace
}

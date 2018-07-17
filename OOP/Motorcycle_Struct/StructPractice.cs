using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *  The C# struct is a lightweight alternative to a class. It can do almost the same as a class, 
 *  but it's less "expensive" to use a struct rather than a class. The reason for this is a bit 
 *  technical, but to sum up, new instances of a class is placed on the heap, where newly 
 *  instantiated structs are placed on the stack. Furthermore, you are not dealing with references 
 *  to structs, like with classes, but instead you are working directly with the struct instance. 
 *  This also means that when you pass a struct to a function, it is by value, instead of as a 
 *  reference. There is more about this in the chapter about function parameters.
 *  
 *  So, you should use structs when you wish to represent more simple data structures.
 * 
 */

namespace StructPractice
{
    class StructPractice
    {

        struct Motorcycle
        {
            private string color;
            private int year;
            private string make;
            private string model;

            public Motorcycle(string color, int year = 0000, string make = "N/A", string model = "N/A")
            {
                this.color = color;
                this.year = year;
                this.make = make;
                this.model = model;
            }

            public string DescribeColor()
            {
                return "This motorcycle is " + Color;
            }

            public string Color
            {
                get { return color; }
                set { color = value; }
            }

            public int Year
            {
                get { return year; }
                set { year = value; }
            }

            public string Make
            {
                get { return make; }
                set { make = value; }
            }

            public string Model
            {
                get { return model; }
                set { model = value; }
            }

            public string Describe()
            {      
                if(this.Make == "N/A" || this.Model == "N/A")
                {
                    return ("A " + this.Color + " Twentieth Century Make and Model Motorcycle");
                }
                else
                {
                    return ("A " + this.Color + " " + this.Year + " " + this.Make + " " + this.Model);
                }

            }

        }


        static void Main(string[] args)
        {
            Motorcycle motorcycle;

            motorcycle = new Motorcycle("Red", 2008, "Honda", "Shadow 750VT");
            Console.WriteLine(motorcycle.Describe());

            motorcycle = new Motorcycle("Black");
            Console.WriteLine(motorcycle.Describe());

            Console.ReadKey();
        }
    }
}

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
            // Polymorphism
            // is great because it will automatically call the proper method for area here

            // Create a Shape object that is a new Rectangle
            Shape rec = new Rectangle(5, 5);

            // create a Shape object that is a new Triangle
            Shape tri = new Triangle(5, 5);

            // We can use the area() function for rectangles
            Console.WriteLine("Rec has an area of " + rec.area() + "\n");
            // for triangles
            Console.WriteLine("Tri has an area of " + tri.area() + "\n");

            // Create a new Rectangle object that is a combination of two new Rectangles
            Rectangle combined = new Rectangle(5, 5) + new Rectangle(5, 5);

            // Display the area using the method we defined
            Console.WriteLine("Combined has an area of " + combined.area() + "\n");

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


    // Abstract class : You cannot instaniate/create an object out of an abstract class
    // is going to define methods that must be defined by those classes that derivered from it
    // You're only going to be able to inherit one abstract class per class
    // However, you can use interfaces to inherit multiple interfaces

    abstract class Shape
    {
        // anyone inheriting from this class must have area since it is defined as abstract
        public abstract double area();

        // This can only be done inside of abstract classes
        // you cannot do this using an interface
        // in other words, abstract classes can actually contain real public methods
        public void sayHi()
        {
            Console.WriteLine("Hello");
        }
    // END of abstract class Shape
    }

    //
    public interface ShapeOfItem
    {
        // This is saying anyone wanting to inherit this class
        // must have a spot defined for area
        double area();

    // END of interface ShapeOfItem
    }

    class Rectangle : Shape
    {
        // Create the Rectangles variables
        private double length;
        private double width;

        // Create the Rectangle Constructor
        public Rectangle(double l, double w)
        {
            length = l;
            width = w;
        }

        // This is overriding the area() function we defined in our abstract class Shape
        // It is defined in Shape, but we have to give it attributes by overridding it
        public override double area()
        {
            return length * width;
        }

        // This is how to overload an operator
        public static Rectangle operator+ (Rectangle r1, Rectangle r2)
        {
            //
            double rLength = r1.length + r2.length;
            double rWidth = r1.width + r2.width;

            //
            return new Rectangle(rLength, rWidth);
        }


    // End of Rectangle : Shape
    }

    //
    class Triangle : Shape
    {
        // Create the Rectangles variables
        private double theBase;
        private double height;

        // Create the Rectangle Constructor
        public Triangle(double b, double h)
        {
            theBase = b;
            height = h;
        }

        // override the area method 
        public override double area()
        {
            return 0.5 * (theBase * height);
        }
    // End of Triangle : Shape
    }

    // We can define classes with generic data types
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

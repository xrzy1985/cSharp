using System;

namespace Shapes
{
    class Shapes
    {
        public double Height { get; set; }
        public double Width { get; set; }

        public Shapes(){ }

        public Shapes(double h, double w)
        {
            this.Height = h;
            this.Width = w;
        }

        public virtual double GetArea()
        {
            double area = this.Height * this.Width;

            return area;

        }

        public virtual string PrintOut()
        {
            String str = "Shape => " + "Height: " + this.Height + " Width: " + this.Width + " Area: " + this.GetArea();

            return str;
        }

        static void Main(string[] args)
        {
            Shapes a = new Shapes(1, 2);

            Shapes b = new Rectangle(4, 5);

            Rectangle c = new Rectangle(7, 8);

            Shapes d = new Triangle(2, 3, 4);

            Shapes e = new Triangle(6, 7, 8);

            Console.WriteLine(a.PrintOut());

            Console.WriteLine(b.PrintOut());

            Console.WriteLine(c.PrintOut());

            Console.WriteLine(d.PrintOut());

            Console.WriteLine(e.PrintOut());

            Console.WriteLine("\nPress any key to close...");
            Console.ReadKey();
        }
    }
}

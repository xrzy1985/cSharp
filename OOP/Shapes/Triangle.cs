using System;

namespace Shapes
{
    class Triangle : Shapes
    {

        public double Base { get; set; }

        public Triangle() { }

        public Triangle(double h, double w, double b)
        {
            this.Height = h;
            this.Width = w;
            this.Base = b;
        }

        public override double GetArea()
        {
            double area = (this.Height * this.Width * this.Base) / 2;

            return area;

        }

        public override string PrintOut()
        {
            String str = "Triangle => " + "Height: " + this.Height + " Width: " + this.Width + " Base: " + this.Base + " Area: " + this.GetArea();

            return str;
        }

    }
}

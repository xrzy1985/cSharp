using System;

namespace Shapes
{
    class Rectangle : Shapes
    {
        public Rectangle() { }

        ~Rectangle() { }

        public Rectangle(double h, double w)
        {
            this.Height = h;
            this.Width = w;
        }

        public override double GetArea()
        {
            return this.Width * this.Height;
        }

        public override string PrintOut()
        {
            String str = "Rectangle => " + "Height: " + this.Height + " Width: " + this.Width + " Area: " + this.GetArea();

            return str;
        }

    }
}

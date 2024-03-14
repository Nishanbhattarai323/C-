using System;


namespace Ncit_Nishan
{
    class Shape { 
    public virtual double CalculateArea()
        {
            Console.WriteLine("Base class Calculate area method");
            return 0;
        }
    }
    class Rectangle : Shape
    {
        public double Length { get; set; }
        public double Breadth { get; set; }
        public Rectangle(double length,double breadth)
        {
            this.Length = length;
            this.Breadth = breadth;
        }
        public override double CalculateArea()
        {
            Console.WriteLine("Derived class CalculateArea method (override)");
            return Length * Breadth;
        }
    }


    internal class Dynamic
    {
        static void Main()
        {
            Shape shape = new Rectangle(7.0, 8.0);
            double area=shape.CalculateArea();
            Console.WriteLine($"Area of Rectangle:{area}");
            Console.WriteLine("Nishan Bhattarai");
            Console.WriteLine("Roll no:26453");
        }
    }
}

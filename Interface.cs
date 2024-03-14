using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ncit_Nishan
{
    public interface Iarea {
        double CalculateArea();
    }
    public class Circle : Iarea
    {
        public double radius { get; set; }
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public double CalculateArea()
        {
            return Math.PI*Math.Pow(radius, 2);
        }
    }

    internal class Interface
    {
        static void Main(string[] args)
        {
            Circle mycircle = new Circle(4.0);
            Console.WriteLine($"Area of the circle:{mycircle.CalculateArea()}");
            Console.WriteLine("Nishan Bhattarai");
            Console.WriteLine("Roll no:26453");
        }
    }
}

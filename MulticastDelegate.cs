using System;


namespace Ncit_Nishan
{
    public delegate void CircleDelegate(double radius);
    class circle
    {
        public void CalculateArea(double radius)
        {
            string result = $"Area of Circle={Math.PI * Math.Pow(radius, 2)}";
            Console.WriteLine(result);
        }
        public void CalculateCircumference(double radius)
        {
            string result = $"Circumference of Circle = {2 * Math.PI * radius}";
            Console.WriteLine(result);

        }
    }
    internal class MulticastDelegate
    {
        static void Main()
        {
            circle mycircle = new circle();

            CircleDelegate cd1 = mycircle.CalculateArea;
            CircleDelegate cd2 = mycircle.CalculateCircumference;

            CircleDelegate cd = cd1 + cd2; // Combines cd1 and cd2

            cd.Invoke(5.0); // Calls both delegates

            Console.WriteLine("------------------------------------");

            cd -= cd1; 

            cd.Invoke(7.5);
            Console.WriteLine("Nishan Bhattarai");
            Console.WriteLine("Roll no:26453");
        }
    }
}

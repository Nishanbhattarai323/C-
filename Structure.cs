using System;


namespace Ncit_Nishan
{
    public struct Point
    {
        // Fields (variables) in the struct
        public int X;
        public int Y;

        // Constructor for the struct
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        // Method to display the coordinates of the point
        public void DisplayCoordinates()
        {
            Console.WriteLine($"Coordinates: ({X}, {Y})");
        }
    }

    class Structure
    {
        static void Main()
        {
            
            Point myPoint = new Point(10, 20);
             Console.WriteLine($"Initial Coordinates: ({myPoint.X}, {myPoint.Y})");
            myPoint.X = 15;
            myPoint.Y = 25;           
            Console.WriteLine($"Updated Coordinates: ({myPoint.X}, {myPoint.Y})");
            myPoint.DisplayCoordinates();
            Console.WriteLine("Nishan Bhattarai");
            Console.WriteLine("Roll no:26453");
        }
    }
}

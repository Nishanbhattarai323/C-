using System;


namespace Ncit_Nishan
{
    internal class FuncDelegate
    {
        static void Main()
        {
            // Example 1: Func with no parameters and an int return type
            Func<int> func1 = () => 42;
            Console.WriteLine(func1()); // Output: 42

            // Example 2: Func with two parameters (int, int) and an int return type
            Func<int, int, int> addFunc = (a, b) => a + b;
            Console.WriteLine(addFunc(5, 7)); // Output: 12

            // Example 3: Func with three parameters (int, int, int) and a string return type
            Func<int, int, int, string> formatFunc = (x, y, z) => $"Result: {x + y + z}";
            Console.WriteLine(formatFunc(2, 3, 4));
            Console.WriteLine("Nishan Bhattarai");
            Console.WriteLine("Roll no:26453");

        }
    }
}

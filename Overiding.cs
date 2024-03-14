using System;

namespace Ncit_Nishan
{
    using System;

    class MathOperation
    {
        // Base class with a virtual method
        public virtual int Multiply(int a, int b)
        {
            Console.WriteLine("Base class Multiply method");
            return a * b;
        }
    }

    class AdvancedMathOperation : MathOperation
    {
        // Derived class with an overridden method
        public override int Multiply(int a, int b)
        {
            Console.WriteLine("Derived class Multiply method (Override)");
            return a * b * 2;
        }

        // Derived class with a hidden (shadowed) method
        public new int Multiply(double a, double b)
        {
            Console.WriteLine("Derived class Multiply method (Hide/Shadow)");
            return (int)(a * b); // Casting to int for simplicity
        }
    }

    class Overiding
    {
        static void Main()
        {
            // Using method overriding
            MathOperation op = new AdvancedMathOperation();
            int resultOverride = op.Multiply(5, 3);
            Console.WriteLine($"Result using method overriding: {resultOverride}");

            // Using method hiding (shadowing)
            AdvancedMathOperation dp = new AdvancedMathOperation();
            int resultHide = dp.Multiply(2.5, 3.5);
            Console.WriteLine($"Result using method hiding: {resultHide}");
            Console.WriteLine("\nNishan Bhattarai");
            Console.WriteLine("\nRollno::26453");
        }
    }

}

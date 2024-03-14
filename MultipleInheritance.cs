using System;


namespace Ncit_Nishan
{
    public interface IDisplayable
    {
        void Display();
    }

    
    public interface ICalculable
    {
        double Calculate();
    }

    
    public class Calculator1 : IDisplayable, ICalculable
    {
        private double operand1;
        private double operand2;

        
        public Calculator1(double operand1, double operand2)
        {
            this.operand1 = operand1;
            this.operand2 = operand2;
        }

        
        public void Display()
        {
            Console.WriteLine($"Operands: {operand1}, {operand2}");
        }

        
        public double Calculate()
        {
            return operand1 + operand2;
        }
    }

    
    class MultipleInheritance
    {
        static void Main()
        {
            // Create an instance of the Calculator class
           Calculator1 myCalculator = new Calculator1(10.5, 20.3);

            // Call methods from both interfaces
            myCalculator.Display();
            Console.WriteLine($"Sum: {myCalculator.Calculate()}");
            Console.WriteLine("\nNishan Bhattarai");
            Console.WriteLine("\nRollno::26453");
        }
    }
}

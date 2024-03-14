using System;


namespace Ncit_Nishan
{
    class Calculator 
    {
        int result;
        public Calculator()
        { 
        result = 0;
            Console.WriteLine("Default Constructor");
        }
        public Calculator(int num1,int num2)
        {
            result = num1+num2;
            Console.WriteLine("Sum of two number:");
            Console.WriteLine("Parameterized Constructor");
        }
        public Calculator(Calculator othercalculator) 
        {
         result=othercalculator.result;
            Console.WriteLine("Copy Constructor");
        }
        public Calculator(int num1,int num2,bool add = true)
        {
            if(add)
            {
                result = num1 +num2;
            }
            else
                result = num1*num2;
            Console.WriteLine("Constructor with optional parameter");
        }
        public void DisplayResult()
        {
            Console.WriteLine("Result:" + result);
        }
    
    }

    internal class Constructor
    {
        static void Main()
        {
            Calculator calc1 = new Calculator();
            calc1.DisplayResult(); // Result: 0
            Console.WriteLine();

            

            // Using Parameterized Constructor 2
            Calculator calc2 = new Calculator(10, 20);
            calc2.DisplayResult(); // Result: 30
            Console.WriteLine();

            // Using Copy Constructor
            Calculator calc3 = new Calculator(calc2);
            calc3.DisplayResult(); // Result: 30
            Console.WriteLine();

            // Using Constructor with Optional Parameter
            Calculator calc4 = new Calculator(3, 4);
            calc4.DisplayResult(); 

            Calculator calc5 = new Calculator(3, 4, false);
            calc5.DisplayResult(); 

            Console.WriteLine("\nNishan Bhattarai");
            Console.WriteLine("\nRollno::26453");
        }
    }
}

using System;


namespace Ncit_Nishan
{
   
    internal class ActionDelegate
    {
        static void Main()
        {
            Action action1 = () => Console.WriteLine("Hello, Action!");
            action1();

           
            Action<int, int> addAction = (a, b) => Console.WriteLine($"Sum: {a + b}");
            addAction(58, 70); 

            Action<string> greetAction = name => Console.WriteLine($"Greetings, {name}!");
            greetAction("John");
            Console.WriteLine("Nishan Bhattarai");
            Console.WriteLine("Roll no:26453");

        }

    }
}

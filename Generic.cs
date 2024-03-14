using System;


namespace Ncit_Nishan
{
    internal class Generic
    {
        static void Main()
        {
            
            List<int> intList = new List<int>();
            intList.Add(5);
            intList.Add(15);
            intList.Add(25);

            Console.WriteLine("List<int> with integers:");
            foreach (int number in intList)
            {
                Console.WriteLine(number);
            }

            
            List<string> stringList = new List<string>();
            stringList.Add("Apple");
            stringList.Add("Banana");
            stringList.Add("Orange");

            Console.WriteLine("\nList<string> with strings:");
            foreach (string fruit in stringList)
            {
                Console.WriteLine(fruit);
              
            }
            Console.WriteLine("Nishan Bhattarai");
            Console.WriteLine("Roll no:26453");
        }
    }
}
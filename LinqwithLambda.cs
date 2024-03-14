using System;
using System.Collections.Generic;
using System.Linq;


namespace Ncit_Nishan
{
    internal class LinqwithLambda
    {
        static void Main()
        {
            // Sample list of integers
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            
            var evenNumbers = numbers.Where(n => n % 2 == 0);

            Console.WriteLine("Even Numbers:");
            foreach (var number in evenNumbers)
            {
                Console.WriteLine(number);
            }

            
            var squaredNumbers = numbers.Select(n => n * n);

            Console.WriteLine("\nSquared Numbers:");
            foreach (var number in squaredNumbers)
            {
                Console.WriteLine(number);
            }


            bool anyNumberGreaterThanFive = numbers.Any(n => n > 5);

            Console.WriteLine($"\nAny number greater than 5? {anyNumberGreaterThanFive}");
            Console.WriteLine("Nishan Bhattarai");
            Console.WriteLine("Roll no: 26453");

        }
    }
}

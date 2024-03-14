using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace Ncit_Nishan
{
    class Linq
    {
        static void Main(string[] args)
        {
            int[] scores = new int[] { 98, 34, 89, 23, 60, 100 };
            var result1 = from src in scores where src < 80 select src;
            Console.WriteLine("Scores less than 80 are:");
            foreach (int i in result1)
            {
                Console.WriteLine(i + " ");
            }
            var result2 = from src in scores where src < 80 orderby src descending select src;
            Console.WriteLine("\n Scores less than 80 in descending order:");
            foreach (int i in result2)
            {
                Console.WriteLine(i + " ");
            }
            Console.WriteLine("Nishan Bhattarai");
            Console.WriteLine("Roll no::26453");
        }
    }
    
}
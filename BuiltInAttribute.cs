using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ncit_Nishan
{
    public class calculator
    {
        [Obsolete("Use Addnumber(List<int> numbers) method")]
        public static int Addnumber(int a, int b)
        {
            return a + b;
        }
        public static int Addnumber(List<int> numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            return sum;
        }
    }
    internal class BuildInAttribute
    {
        [Obsolete]
        static void Main(string[] args)
        {
            int c = calculator.Addnumber(11, 22);
            Console.WriteLine("The sum of two number is :" + c);
            int b = calculator.Addnumber(new List<int> { 11, 23, 45, 67 });
            Console.WriteLine("The sum of numbers of list : " + b);
            
            Console.WriteLine(" Name : Nishan Bhattarai");
            Console.WriteLine(" Roll No:26453");
        }

    }
}
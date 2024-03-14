using System;

namespace Ncit_Nishan
{
    class Democalc<T>
    {
        public void Sum<T>(T x, T y)
        {
            dynamic a = x;
            dynamic b = y;
            Console.WriteLine($"Sum: {a + b}");
        }

        public void Diff<T>(T x, T y)
        {
            dynamic a = x;
            dynamic b = y;
            Console.WriteLine($"Difference: {a - b}");
        }

        public void Mul<T>(T x, T y)
        {
            dynamic a = x;
            dynamic b = y;
            Console.WriteLine($"Multiplication: {a * b}");
        }
    }

    internal class GenericClass
    {
        static void Main(string[] args)
        {
            Democalc<int> obj = new Democalc<int>();
            obj.Sum<int>(6, 7);
            obj.Diff<int>(63, 34);
            obj.Mul<int>(12, 13);
            Console.WriteLine("Nishan Bhattarai");
            Console.WriteLine("Roll no: 26453");
        }
    }
}

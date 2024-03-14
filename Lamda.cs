using System;


namespace Ncit_Nishan
{
    public delegate string GreetDelegate(string name);
    internal class Lamda
    {
        public string SayHello(string name)
        {
            return $"hello{name}";
        }
        static void Main(string[] args)
        {
            Lamda demo = new Lamda();
            GreetDelegate gd = (name) =>
            {
                return $"Hello{name}";
            };
            string msg = gd("Nishan");
            Console.WriteLine(msg);

        }
    }
}
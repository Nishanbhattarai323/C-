using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ncit_Nishan
{
    public delegate void Notify();
    public class car
    {
        public event Notify readytostart;
        public void Start()
        {
            Console.WriteLine("\t Engine Start");
            Console.WriteLine("\t Broom...Broom");
            Onreadytostart();
        }
        protected virtual void Onreadytostart()
        {
            readytostart?.Invoke();
        }

    }

    internal class Event
    {
        public static void Main(string[] args)
        {
            car car1 = new car();
            car1.readytostart += car1_readytostart;
            car1.Start();
        }
        public static void car1_readytostart()
        {
            Console.WriteLine("\t Car runned");
            Console.WriteLine("Nishan Bhattarai");
            Console.WriteLine("Roll no:26453");
        }
    }
}

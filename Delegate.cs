using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ncit_Nishan
{
    public delegate string TestDelegate(String s);
    internal class Delegate
    {
        public string Greet(string name)
        {
            return "Hello" + name + "Namaste";
        }
        public void SayHello(string name)
        {
            Console.WriteLine("Hello" + name + "Namaste");
        }
        static void Main()
        {
            Delegate dt= new Delegate();
            TestDelegate cd = dt.Greet;
            string msg = cd("Nishan");
            Console.WriteLine(msg);
            Console.WriteLine("Nishan Bhattarai");
            Console.WriteLine("Roll no:26453");
        }

    }
}

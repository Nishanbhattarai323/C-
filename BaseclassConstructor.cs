using System;

namespace Ncit_Nishan
{
    class vehicle {
        public string brand;
        public vehicle(string brand)
        {
            this.brand = brand;
            Console.WriteLine($"Base class constructor called.Brand:{brand}");
        }
    }
    class Truck : vehicle
    {
        public string model;
        public Truck(string brand,string model):base(brand)
        {
           this.model = model;
            Console.WriteLine($"Derived class Constructor called.Model:{model}");
        }
    }

    internal class BaseclassConstructor
    {
        static void Main()
        {
            Truck mytruck = new Truck("Tata", "Lpt138");
            Console.WriteLine($"Brand:{mytruck.brand},Model:{mytruck.model}");
            Console.WriteLine("Nishan Bhattarai");
            Console.WriteLine("Roll no:26453");
        }
    }
}

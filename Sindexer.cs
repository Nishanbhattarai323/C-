using System;

namespace Ncit_Nishan
{
    class Car
    {
        string name;
        double price;
        string model;
        string color;

        public Car(string name, double price, string model, string color)
        {
            this.name = name;
            this.price = price;
            this.model = model;
            this.color = color;
        }

        public object this[string idx]
        {
            get
            {
                if (idx == "name")
                    return this.name;
                else if (idx == "price")
                    return this.price;
                else if (idx == "model")
                    return this.model;
                else if (idx == "color")
                    return this.color;
                else
                    return "Invalid index";
            }
            set
            {
                if (idx == "name")
                    this.name = (string)value;
                else if (idx == "price")
                    this.price = (double)value;
                else if (idx == "model")
                    this.model = (string)value;
                else if (idx == "color")
                    this.color = (string)value;
                else
                    Console.WriteLine("Invalid index");
            }
        }
    }

    internal class Sindexer
    {
        static void Main(string[] args)
        {
            Car car1;
            car1 = new Car("swift", 3000000.0, "base", "red");

            Console.WriteLine($"Name: {car1["name"]}");
            Console.WriteLine($"Price: {car1["price"]}");
            Console.WriteLine($"Model: {car1["model"]}");
            Console.WriteLine($"Color: {car1["color"]}");

            Console.WriteLine("..........NishanBhattarai......");
            Console.WriteLine("Rollno::26453");
        }
    }
}

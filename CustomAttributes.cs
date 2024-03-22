using System;

namespace Ncit_Nishan
{
    // Custom attribute MyAttribute
    [AttributeUsage(AttributeTargets.All)]
    public class MyAttribute : Attribute
    {
        private string description;

        // Constructor to initialize attribute data
        public MyAttribute(string description)
        {
            this.description = description;
        }

        // Property to retrieve attribute data
        public string Description
        {
            get { return description; }
        }
    }

    // A class representing a Car
    class Car1
    {
        private string brand;
        private string model;
        private int year;

        // Constructor
        public Car1(string brand, string model, int year)
        {
            this.brand = brand;
            this.model = model;
            this.year = year;
        }

        // Method to display car details
        [MyAttribute("Displays car details")]
        public void DisplayDetails()
        {
            Console.WriteLine("Car Details:");
            Console.WriteLine("Brand: " + brand);
            Console.WriteLine("Model: " + model);
            Console.WriteLine("Year: " + year);
        }
    }

    class CustomAttributes
    {
        // Main Method
        static void Main(string[] args)
        {
            // Create an instance of Car class
            Car1 myCar = new Car1("Toyota", "Corolla", 2022);

            // Display car details
            myCar.DisplayDetails();

            // Get custom attribute information
            Attribute[] attributes = Attribute.GetCustomAttributes(typeof(Car));
            foreach (Attribute attribute in attributes)
            {
                if (attribute is MyAttribute)
                {
                    MyAttribute myAttribute = (MyAttribute)attribute;
                    Console.WriteLine("\nAttribute Description: " + myAttribute.Description);
                }
            }
        }
    }
}


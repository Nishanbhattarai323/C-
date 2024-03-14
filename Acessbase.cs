using System;
namespace Ncit_Nishan
{
    class Animal
    {
        public string Name;

        public Animal(string name)
        {
            Name = name;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Animal: {Name}");
        }
    }

    class Dog : Animal
    {
        public string Breed;

        public Dog(string name, string breed) : base(name)
        {
            Breed = breed;
        }

        // Method in the derived class that uses base keyword
        public void DisplayDogInfo()
        {
            // Accessing base class field using base keyword
            Console.WriteLine($"Dog: {base.Name}, Breed: {Breed}");
        }
    }

    class Acessbase
    {
        static void Main()
        {
            Dog myDog = new Dog("Buddy", "Labrador");

            // Accessing base class method
            myDog.DisplayInfo();

            // Accessing derived class method using base keyword
            myDog.DisplayDogInfo();
            Console.WriteLine("\nNishan Bhattarai");
            Console.WriteLine("\nRollno::26453");
        }
    }
}
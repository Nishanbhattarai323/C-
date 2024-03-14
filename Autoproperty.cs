using System;
namespace Ncit_Nishan
{
    class Person
    {
        // Auto-Property
        public string FirstName { get; set; }

        // Auto-Property with Private Set
        public string LastName { get; private set; }

        // Read-Only Property
        public int Age { get; }

        
        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {FirstName} {LastName}, Age: {Age}");
        }
    }

    class Autoproperty
    {
        static void Main()
        {
            // Creating an instance of the Person class
            Person person = new Person("John", "Doe", 25);

            
            Console.WriteLine($"First Name: {person.FirstName}");
            person.FirstName = "Jane";  // Changing the value using Auto-Property
            Console.WriteLine($"Updated First Name: {person.FirstName}");
            Console.WriteLine();

            // Using Auto-Property with Private Set
            Console.WriteLine($"Last Name: {person.LastName}"); 
            Console.WriteLine();

            // Using Read-Only Property
            Console.WriteLine($"Age: {person.Age}");  
            Console.WriteLine();

            // Displaying the complete information using the DisplayInfo method
            person.DisplayInfo();
        }
    }
}
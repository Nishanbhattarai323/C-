using System;

namespace Ncit_Nishan
{
    using System;

    // Abstract class for Employee details
    abstract class Employee
    {
        // Properties
        public string EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public abstract double CalculateSalary(); // Abstract method to be implemented by derived classes

        // Method to display employee details
        public void DisplayDetails()
        {
            Console.WriteLine($"Employee ID: {EmployeeId}");
            Console.WriteLine($"Name: {FirstName} {LastName}");
            Console.WriteLine($"Salary: {CalculateSalary()}"); // Calls the abstract method
        }
    }

    // Derived class representing a Full-Time Employee
    class FullTimeEmployee : Employee
    {
        public double MonthlySalary { get; set; }

        // Implementation of the abstract method for Full-Time Employee
        public override double CalculateSalary()
        {
            return MonthlySalary;
        }
    }

    
    

    class Abstract
    {
        static void Main()
        {
            // Create a Full-Time Employee
            FullTimeEmployee fullTimeEmployee = new FullTimeEmployee
            {
                EmployeeId = "FT001",
                FirstName = "John",
                LastName = "Doe",
                MonthlySalary = 5000
            };

            // Display Full-Time Employee details
            Console.WriteLine("Full-Time Employee Details:");
            fullTimeEmployee.DisplayDetails();

            Console.WriteLine("Nishan Bhattarai");
            Console.WriteLine("Roll no:26453");
           
        }
    }

}

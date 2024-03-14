using System;

namespace Ncit_Nishan
{
    class Teacher
    {
        int eid;
        string name;
        string department;
        double salary;

        public Teacher(int eid, string name, double salary, string department)
        {
            this.eid = eid;
            this.name = name;
            this.salary = salary;
            this.department = department;
        }

        public object this[int index]
        {
            get
            {
                if (index == 0)
                    return this.eid;
                else if (index == 1)
                    return this.name;
                else if (index == 2)
                    return this.salary;
                else if (index == 3)
                    return this.department;
                else
                    return "Invalid index";
            }
            set
            {
                if (index == 0)
                    this.eid = (int)value;
                else if (index == 1)
                    this.name = (string)value;
                else if (index == 2)
                    this.salary = (double)value;
                else if (index == 3)
                    this.department = (string)value;
                else
                    Console.WriteLine("Invalid index");
            }
        }
    }

    internal class Indexer
    {
        static void Main(string[] args)
        {
            Teacher tech1;
            tech1 = new Teacher(1001, "Nishan", 80000.0, "CSIT");

            // Example of using indexer
            Console.WriteLine($"Employee ID: {tech1[0]}");
            Console.WriteLine($"Name: {tech1[1]}");
            Console.WriteLine($"Salary: {tech1[2]}");
            Console.WriteLine($"Department: {tech1[3]}");
            Console.WriteLine("..........NishanBhattarai......");
            Console.WriteLine("Rollno::26453");
        }
    }
}

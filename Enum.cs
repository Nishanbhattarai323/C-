using System;

namespace Ncit_Nishan
{
    class Enum
    {
        enum Days { Sun, Mon, Tue, Wed, Thu, Fri, Sat };

        static void Main(string[] args)
        {
            // Using enum values
            Days startDay = Days.Wed;
            Days endDay = Days.Sat;

            Console.WriteLine("Start Day: {0}", startDay);
            Console.WriteLine("End Day: {0}", endDay);

            // Converting enum values to integers
            int startValue = (int)startDay;
            int endValue = (int)endDay;

            Console.WriteLine("Start Value: {0}", startValue);
            Console.WriteLine("End Value: {0}", endValue);

            Console.ReadKey();
            Console.WriteLine("\nNishan Bhattarai");
            Console.WriteLine("Rollno::26453");
        }
    }
}

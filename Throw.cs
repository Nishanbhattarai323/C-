using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ncit_Nishan
{
    class Throw
    {
        static void Main()
        {
            try
            {
                Console.Write("Enter a number: ");
                int userInput = int.Parse(Console.ReadLine());

                if (userInput == 0)
                {
                    throw new DivideByZeroException("Cannot divide by zero.");
                }

                int result = 10 / userInput;
                Console.WriteLine($"Result of division: {result}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");

                // Rethrowing the exception with additional information
                throw new Exception("Custom exception message", ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected Error: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Finally block executed.");
            }

            Console.WriteLine("Program continues after exception handling.");
        }
    }

}

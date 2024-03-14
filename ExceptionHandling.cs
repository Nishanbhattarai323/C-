using System;
namespace Ncit_Nishan
{
    class ExceptionHandling
    {
        static void Main()
        {
            try
            {

                Console.Write("Enter a number: ");
                int userInput = int.Parse(Console.ReadLine());


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
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Unexpected Error: {ex.Message}");
            }
            finally
            {

                Console.WriteLine("Finally block executed.");
            }

            // Rest of the code after exception handling
            Console.WriteLine("Program continues after exception handling.");
            Console.WriteLine("Nishan Bhattarai");
            Console.WriteLine("Roll no:26453");
        }
    }
}
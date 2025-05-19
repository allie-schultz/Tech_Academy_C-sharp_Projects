using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingAssignment
{
    internal class Program
    {
        static void Main()
        {
           
            try
            {
                List<int> numbers = new List<int>() { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 };
                Console.WriteLine("Enter a number to divide each element in the list:");
                int input = Convert.ToInt32(Console.ReadLine());

                if (input == 0)
                {
                    throw new DivideByZeroException("Division by zero is not allowed.");
                }

                else
                {
                    foreach (int number in numbers)
                    {
                        double result = (double)number / input;
                        Console.WriteLine($"{number} / {input} = {result:F2}");
                    }
                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Error: Invalid input format. Enter a number.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnumsAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DaysOfWeek currentDay;

            try
            {
                Console.WriteLine("Please enter the current day of the week");
                string input = Console.ReadLine();
                currentDay = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), input, true);
                Console.WriteLine($"Today is {currentDay}.");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Please enter an actual day of the week");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            Console.ReadLine();
        }
        public enum DaysOfWeek
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }
    }
}

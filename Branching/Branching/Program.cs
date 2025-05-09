using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching
{
    internal class Program
    {
        static void Main()
        {
           Console.WriteLine("Welcome to Package Express. Please follow the Instruction below");

            Console.WriteLine("Please enter the package weight in pounds:");
            int weight = Convert.ToInt32(Console.ReadLine());
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                return;
            }
            else if (weight <= 50)
            {
                Console.WriteLine("Please enter the package width in inches:");
                int width = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the package height in inches:");
                int height = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the package length in inches:");
                int length = Convert.ToInt32(Console.ReadLine());

                if (width + height + length > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                    Console.ReadLine();
                }
                else
                {
                    decimal totalCost = (width * height * length * weight) / 100.00m;
                    Console.WriteLine("Your estimated total for shipping this package is: $" + totalCost.ToString("F2"));
                    Console.ReadLine();
                }
            }
        }
    }
}

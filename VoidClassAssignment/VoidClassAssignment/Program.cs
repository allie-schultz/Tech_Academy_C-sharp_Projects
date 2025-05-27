using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidClassAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Division division = new Division();

            Console.WriteLine("Enter a number to divide by 2: ");
            string input = Console.ReadLine();
            int num;

            if (int.TryParse(input, out num))
            {
                int result;
                division.DivideBy2(num, out result);
                Console.WriteLine($"The result of dividing {num} by 2 is: {result}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }

            double doubleNum = 36.7;
            double doubleResult;
            division.DivideBy2(doubleNum, out doubleResult);
            Console.WriteLine($"The result of dividing {doubleNum} by 2 is: {doubleResult}");

            double intNum = 100.00;
            double intResult = DivisionHelper.DivideBy5(intNum);
            Console.WriteLine("100 / 5 = " + intResult);
            Console.ReadLine();

      


        }
    }
}

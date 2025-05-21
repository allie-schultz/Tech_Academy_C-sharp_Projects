using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick a number to perform math operations on:");
            string input = (Console.ReadLine());
            int number;
            if (int.TryParse(input, out number))
            {
                Console.WriteLine("You entered: " + number);

                Math math = new Math();

                int addResult = math.Add(number);
                Console.WriteLine("Addition result: " + addResult);

                int subtractResult = math.Subtract(number);
                Console.WriteLine("Subtraction result: " + subtractResult);

                int multiplyResult = math.Multiply(number);
                Console.WriteLine("Multiplication result: " + multiplyResult);
            }

            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
            Console.ReadLine();

        }
    }
}

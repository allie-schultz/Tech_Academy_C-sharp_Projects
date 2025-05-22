using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodWithOptionalParameterAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            twoParameters mult = new twoParameters();

            Console.WriteLine("Please enter an integer:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter another integer (or press Enter to use the default value of 2):");
            string input = Console.ReadLine();
            int num2;
            if (string.IsNullOrEmpty(input))
            {
                num2 = 2; // Default value
            }
            else
            {
                num2 = Convert.ToInt32(input);
            }

            int result = mult.Multiply(num1, num2);
            Console.WriteLine(num1 + " * " + num2 + " = " + result );
            Console.ReadLine();
        }
    }
}

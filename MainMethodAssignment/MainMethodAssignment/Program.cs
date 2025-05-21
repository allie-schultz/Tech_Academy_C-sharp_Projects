using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int value = 5;
            Console.WriteLine("We are performing opperations on an int, decimal, and string");
            Calculation calc = new Calculation();

            // Call the method with an int
            int result = calc.Opperation(value);
            Console.WriteLine(value + " + " + value + " = " + result);

            // Call the method with a decimal
            decimal decimalValue = 10.7m;
            double resultDecimal = calc.Opperation(decimalValue);
            Console.WriteLine(decimalValue + " / 2 = " + resultDecimal);

            // Call the method with a string
            string stringValue = "7";
            int resultString = calc.Opperation(stringValue);
            Console.WriteLine(stringValue + " * " + stringValue + " = " + resultString);

            Console.ReadLine();
        }
    }
}

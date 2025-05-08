using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousIncomeComparisonAssignment
{
    internal class Program
    {
        static void Main()
        {
            //Income Comparison Assignment

            Console.WriteLine("Anonymous Income Comparison Program");

            //Person 1 Inputs
            Console.WriteLine("Person 1");
            Console.WriteLine("Enter Hourly Rate Below:");
            string hourlyRate1 = Console.ReadLine();
            Console.WriteLine("Enter Hours Worked Per Week Below:");
            string hoursWorked1 = Console.ReadLine();

            //Person 2 Inputs
            Console.WriteLine("Person 2");
            Console.WriteLine("Enter Hourly Rate Below:");
            string hourlyRate2 = Console.ReadLine();
            Console.WriteLine("Enter Hours Worked Per Week Below:");
            string hoursWorked2 = Console.ReadLine();

            //Person 1 Annual Salary
            double salary1 = Convert.ToDouble(hourlyRate1) * Convert.ToDouble(hoursWorked1) * 52;
            Console.WriteLine("Person 1 Annual Salary: \n" + salary1);
            Console.ReadLine();

            //Person 2 Annual Salary
            double salary2 = Convert.ToDouble(hourlyRate2) * Convert.ToDouble(hoursWorked2) * 52;
            Console.WriteLine("Person 2 Annual Salary: \n" + salary2);
            Console.ReadLine();

            //Comparison
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool comparison = salary1 > salary2;
            Console.WriteLine(comparison);
            Console.ReadLine();
        }
    }
}

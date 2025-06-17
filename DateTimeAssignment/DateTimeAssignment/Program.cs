using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Print current date and time
            DateTime currentDateTime = DateTime.Now;
            Console.WriteLine("Current Date and Time: " + currentDateTime);
            //As user for nukber
            Console.WriteLine("Enter a number: ");
            string input = Console.ReadLine();
            //Tell time it will be in that may hours
            Console.WriteLine("In " + input + " hours, it will be: " + currentDateTime.AddHours(Convert.ToDouble(input))); //Converts user input to double and adds it to current time
            Console.ReadLine();
        }
    }
}

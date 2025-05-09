using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogic
{
    internal class Program
    {
        static void Main()
        {
            //Car insurance approval program

            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Have you ever had a DUI? (true/false)");
            bool dui = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("How many speeding tickets do you have?");
            int tickets = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Qualified for car insurance?");
            Console.WriteLine(age > 15 && !dui && tickets <= 3);
            Console.ReadLine();

        }
    }
}

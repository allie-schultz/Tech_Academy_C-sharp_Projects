using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAssignment
{
    internal class Program
    {
        static void Main()
        {
            //String Array with user input
            string[] stringArray = { "are beautiful", "got this", "can do it", "are strong", "are loved" };
            Console.WriteLine("Please choose an array index between 0 and 4:");
            int index = Convert.ToInt32(Console.ReadLine());
            if (index >= 0 && index < stringArray.Length)
            {
                Console.WriteLine($"You {stringArray[index]}!");
            }
            else
            {
                Console.WriteLine("Sorry, invalid number. Please enter a number between 0 and 4.");
            }

            //int array with user input
            int[] intArray = { 0, 1, 2, 3, 4 };
            Console.WriteLine("Please choose an array index between 0 and 4:");
            int index2 = Convert.ToInt32(Console.ReadLine());
            if (index2 >= 0 && index2 < intArray.Length)
            {
                Console.WriteLine($"You chose index number {intArray[index2]}.");
            }
            else
            {
                Console.WriteLine("Sorry, invalid number. Please enter a number between 0 and 4.");
            }

            //List of strings withuser input
            List<string> stringList = new List<string> { "20 crunches", "15 pushups", "30 jumping-jacks", "a 1 minute plank", "20 squats" };
            Console.WriteLine("Please choose an array index between 0 and 4 to get a simple exercise:");
            int index3 = Convert.ToInt32(Console.ReadLine());
            if (index3 >= 0 && index3 < stringList.Count)
            {
                Console.WriteLine($"You should do {stringList[index3]}.");
            }
            else
            {
                Console.WriteLine("Sorry, invalid number. Please enter a number between 0 and 4.");
            }
            Console.Read();
        }
    }
}

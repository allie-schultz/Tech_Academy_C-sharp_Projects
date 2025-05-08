using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReportAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("\nStudent Daily Report");

            Console.WriteLine("\nWhat is your name?");
            string studentName = Console.ReadLine(); // reads name input

            Console.WriteLine("\nWhat course are you on?");
            string courseName = Console.ReadLine(); // reads course input

            Console.WriteLine("\nWhat page number?");
            string pageNumber = Console.ReadLine(); // reads page number input
            int pageNumberInt = Convert.ToInt32(pageNumber); // converts string to int

            Console.WriteLine("\nDo you need help with anything? Please answer \"true\" or \"false\".");
            string help = Console.ReadLine(); // reads student help input

            Console.WriteLine("\nWere there any positive experiences you would like to share? Please give specifics."); // reads experience input
            string experience = Console.ReadLine();

            Console.WriteLine("\nIs there any other feedback you would like to provide? Please be specific."); // reads feedback input
            string feedback = Console.ReadLine();

            Console.WriteLine("\nHow many hours did you study today?"); // reads study hours input
            string studyHours = Console.ReadLine();
            int studyHoursInt = Convert.ToInt32(studyHours); // converts string to int

            Console.WriteLine("Thank you for your answers. An Instructor will respond shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}

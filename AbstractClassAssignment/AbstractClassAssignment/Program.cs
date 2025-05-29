using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of Employee
            Employee employee = new Employee(); //inheriting from iQuittable interace as well
            employee.firstName = "Sample";
            employee.lastName = "Student";
            employee.ID = 1;
            // Call the SayName method
            employee.SayName();

            //Assign employee to IQuittable interface
            IQuittable quit = employee;
            // Call the Quit method
            quit.Quit();

            Console.ReadLine();
        }
    }
}

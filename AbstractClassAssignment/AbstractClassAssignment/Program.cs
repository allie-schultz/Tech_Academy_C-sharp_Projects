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

            // Create another Employee with different ID
            Employee employee2 = new Employee();
            employee2.firstName = "Another";
            employee2.lastName = "Student";
            employee2.ID = 2; 

            // Call the SayName method
            employee.SayName();
            employee2.SayName();

            //Assign employee to IQuittable interface
            IQuittable quit = employee;
            // Call the Quit method
            quit.Quit();

            // Demonstrate operator overloading
            Console.WriteLine($"Are employees the same? {employee == employee2}");
            Console.WriteLine($"Are employees different? {employee != employee2}");

            Console.ReadLine();
        }
    }
}

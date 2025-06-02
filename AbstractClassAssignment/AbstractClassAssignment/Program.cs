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

            // Create a generic type parameter for Employee 
            Employee<string> stringThings = new Employee<string>();
            Employee<int> intThings = new Employee<int>();
            // Create an instance of Employee
            Employee<string> employee = new Employee<string>(); //inheriting from iQuittable interace as well
            employee.firstName = "Sample";
            employee.lastName = "Student";
            employee.ID = 1;

            // Create another Employee with different ID
            Employee<string> employee2 = new Employee<string>();
            employee2.firstName = "Another";
            employee2.lastName = "Student";
            employee2.ID = 2;

            // Add some string data to the generic list
            stringThings.Things = new List<string> { "Task1", "Task2", "Task3" };
            // Addf some integer data to the generic list
            intThings.Things = new List<int> { 1, 2, 3 };


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

            // foreach loop to display string data
            Console.WriteLine("String Things:");
            foreach (var item in stringThings.Things)
            {
                Console.WriteLine(item);
            }
            // foreach loop to display integer data
            Console.WriteLine("Integer Things:");
            foreach (var item in intThings.Things)
            {
                Console.WriteLine(item);
            }


            Console.ReadLine();
        }
    }
}

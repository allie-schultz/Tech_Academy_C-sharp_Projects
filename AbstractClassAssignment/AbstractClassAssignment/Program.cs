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

            //List of 10 Employees
            List<Employee<string>> employees = new List<Employee<string>>()
            {
                new Employee<string> { firstName = "John", lastName = "Doe", ID = 1 },
                new Employee<string> { firstName = "Jane", lastName = "Smith", ID = 2 },
                new Employee<string> { firstName = "Alice", lastName = "Johnson", ID = 3 },
                new Employee<string> { firstName = "Joe", lastName = "Brown", ID = 4 }, //Joe 1
                new Employee<string> { firstName = "Charlie", lastName = "Davis", ID = 5 },
                new Employee<string> { firstName = "Eve", lastName = "Wilson", ID = 6 },
                new Employee<string> { firstName = "Joe", lastName = "Garcia", ID = 7 }, //Joe 2
                new Employee<string> { firstName = "Grace", lastName = "Martinez", ID = 8 },
                new Employee<string> { firstName = "Hank", lastName = "Lopez", ID = 9 },
                new Employee<string> { firstName = "Ivy", lastName = "Gonzalez", ID = 10 }
            };

            // Find and print all employees with the first name "Joe" using foreach
            Console.WriteLine("Employees with the first name 'Joe':");
            List<Employee<string>> joeEmployees = new List<Employee<string>>();
            foreach (var emp in employees)
            {
                if (emp.firstName == "Joe")
                {
                    joeEmployees.Add(emp);
                    Console.WriteLine($"Name: {emp.firstName} {emp.lastName}, ID: {emp.ID}");
                }
            }
            // Find and print all employees with the first name "Joe" using lambda expression
            Console.WriteLine("Employees with the first name 'Joe' using lambda expression:");
            var joeEmployeesLambda = employees.Where(emp => emp.firstName == "Joe").ToList();
            //print list from lambda expression
            foreach (var emp in joeEmployeesLambda)
            {
                Console.WriteLine($"Name: {emp.firstName} {emp.lastName}, ID: {emp.ID}");
            }
            //Employees with ID greater than 5
            var greaterThan5 = employees.Where(emp => emp.ID > 5).ToList();
            Console.WriteLine("Employees with ID greater than 5:");
            foreach (var emp in greaterThan5)
            {
                Console.WriteLine($"Name: {emp.firstName} {emp.lastName}, ID: {emp.ID}");
            }

            Console.ReadLine();
        }
    }
}

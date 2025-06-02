using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    public class Employee<T> : Person, IQuittable //inherites interface IQuittable and abstract class Person
    {
        public int ID { get; set; }
        public List<T> Things { get; set; } //generic list to hold any type of data

        public override void SayName()
        {
            Console.WriteLine($"Name: {firstName} {lastName}");
        }

        //Polymoriphism Assignment Part
        public void Quit()
        {
            Console.WriteLine($"{firstName} {lastName} has quit the job.");
        }

        public static bool operator== (Employee<T> employee1, Employee<T> employee2)
        {
            return employee1.ID == employee2.ID;
        }
        public static bool operator !=(Employee<T> employee1, Employee<T> employee2)
        {
            return !(employee1 == employee2);
        }

        public override bool Equals(object obj)
        {
            Employee<T> otherEmployee = (Employee<T>)obj; // Cast to Employee
            return ID == otherEmployee.ID;          // Compare IDs
        }
        public override int GetHashCode()
        {
            return ID.GetHashCode();
        }
    }
}

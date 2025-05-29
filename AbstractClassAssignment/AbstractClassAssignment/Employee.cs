using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    public class Employee : Person, IQuittable //inherites interface IQuittable and abstract class Person
    {
        public int ID { get; set; }

        public override void SayName()
        {
            Console.WriteLine($"Name: {firstName} {lastName}");
        }

        //Polymoriphism Assignment Part
        public void Quit()
        {
            Console.WriteLine($"{firstName} {lastName} has quit the job.");
        }
    }
}

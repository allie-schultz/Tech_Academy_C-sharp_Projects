using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Number num;
            num.Amount = 123.456m;
            Console.WriteLine("The amount is: " + num.Amount);
            Console.ReadLine();
        }
        public struct Number
        {
            public decimal Amount;
        }
    }
}

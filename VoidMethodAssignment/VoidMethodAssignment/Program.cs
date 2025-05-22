using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethodAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            voidMethod vm = new voidMethod();

            int numa = 5;
            int numb = 10;

            Console.WriteLine("Parameter passed regularly:");
            vm.twoInts(numa, numb);
            Console.WriteLine("\nParameter passed by reference:");
            vm.twoInts(a: numa, b: numb);
            Console.ReadLine();

        }
    }
}

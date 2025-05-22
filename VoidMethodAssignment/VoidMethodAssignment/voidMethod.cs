using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethodAssignment
{
    public class voidMethod
    {
        public void twoInts(int a, int b)
        {
           int Mult = a * 3;
            Console.WriteLine(a + " * 3 = " + Mult);
            Console.WriteLine("The second integer is: " + b);
        }
    }
}

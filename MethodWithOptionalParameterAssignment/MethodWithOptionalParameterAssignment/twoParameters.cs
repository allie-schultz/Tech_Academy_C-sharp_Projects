using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodWithOptionalParameterAssignment
{
    public class twoParameters
    {
        public int Multiply(int num1, int num2 = 2)
        {
            return num1 * num2;
        }
    }
}

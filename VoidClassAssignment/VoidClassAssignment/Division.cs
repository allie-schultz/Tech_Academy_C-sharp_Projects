using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidClassAssignment
{
    public class Division
    {
        public void DivideBy2(double number, out  double result)
        {
            double num = Convert.ToDouble(number);
            result = num / 2;
        }

        public void DivideBy2(int number, out int result)
        {
            int num = Convert.ToInt32(number);
            result = num / 2;
        }
    }

    public static class DivisionHelper
        {
            public static double DivideBy5(double divisor)
            {
                return divisor / 5;
            }
        }
    
}

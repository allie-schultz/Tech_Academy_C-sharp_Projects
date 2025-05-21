using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    internal class Calculation
    {
        public int Opperation(int num)
        {
            return num + num;
        }

        public double Opperation(decimal num)
        {
            decimal intermediateNum = (num / 2);
            double result = (double)intermediateNum;
            return result;
        }

        public int Opperation(string num)
        {
            int convertedNum = Convert.ToInt32(num);
            int result = convertedNum * convertedNum;
            return result;
        }


    }
}

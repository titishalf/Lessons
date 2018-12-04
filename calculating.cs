using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class calculate
    {
        public double Add(double index1, double index2)
        {
            return index1 + index2;
        }
       
        public double Divide(double index1, double index2)
        {
            if (index2 == 0)
            {
                throw new Exception("index 2 should not be equal to zero");
            }
            return index1 / index2;
        }
        public double Substract(double index1, double index2)
        {
            return index1 - index2;
        }
        public double Multiply(double index1, double index2)
        {
            return index1 * index2;
        }
    }
}

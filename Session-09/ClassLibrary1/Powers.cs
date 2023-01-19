using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcLibrary
{
    public class Powers
    {
        public decimal Power(decimal numOne, decimal numTwo)
        {
            decimal result = 0;
            if (numOne != null && numTwo != null)
            {
                double powerOne = Convert.ToDouble(numOne);
                double powerTwo = Convert.ToDouble(numTwo);
                result = Convert.ToDecimal(Math.Pow(powerOne, powerTwo));
            }
            else { }
            return result; 

        }
    }
}

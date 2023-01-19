using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcLibrary
{
    public class Roots
    {
        public decimal SquareRoot(decimal num)
        {
            double root = Convert.ToDouble(num);
            decimal result = Convert.ToDecimal(Math.Sqrt(root));
            return result;
        }
    }
}

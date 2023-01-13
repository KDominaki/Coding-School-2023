using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    internal class UsersNum
    {
        public int SumAll(int num) 
        {
            int res = 0;

            for (int i = 0; i < num + 1; i++)
            {
                res += i;
            }

            return res;
        }

        public int ProductAll(int num)
        {
            int res = 1;

            for (int i = 1; i < num + 1; i++)
            {
                res *= i;
            }

            return res;
        }
    }
}

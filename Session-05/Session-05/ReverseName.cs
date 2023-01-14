using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    internal class ReverseString
    {
        public string Reverse(string text) 
        {
            char[] cArray = text.ToCharArray();
            string revName = "";
            for (int i = cArray.Length - 1; i > -1; i--)
            {
                revName += cArray[i];
            }
            return revName;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Populate
    {
        public void PopulateTrans(List<Transaction> transList)
        {
            Transaction trans1 = new Transaction()
            {
                TotalPrice= 1000,
            };
            transList.Add(trans1);
        }
    }
}

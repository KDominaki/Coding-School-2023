using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class MonthlyLedgerManager
    {
        private DateTime _date = DateTime.Now;
        public List<MonthlyLedger> mothLegList = new List<MonthlyLedger> ();
        
        public void  MonthlyLedgerGenerator()
        {
            //MonthlyLedger monthlyLedger = new MonthlyLedger(_date.Year, _date.Month );
            mothLegList.Add(new MonthlyLedger(_date.Year, _date.Month));
        }
    }
}

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
        public MonthlyLedger currentMonth { get; set; }
        
        public void  MonthlyLedgerGenerator()
        {
            //MonthlyLedger monthlyLedger = new MonthlyLedger(_date.Year, _date.Month );
            mothLegList.Add(new MonthlyLedger(_date.Year, _date.Month));
        }

        public void CurrentMonthChanger()
        {
            currentMonth = mothLegList[^1];
        }

        public void GeneratorActivator()
        {
            if(_date.Day == 1){
                MonthlyLedgerGenerator();
            }
            else { }
        }

        public decimal? CurrentMonthTotal()
        {
            GeneratorActivator();
            currentMonth.TotalCalc();
            decimal? currentMonthTotal = currentMonth.Total; 
            return currentMonthTotal;
        }





    }
}

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
        public List<MonthlyLedger> monthLegList = new List<MonthlyLedger> ();
        public MonthlyLedger currentMonthlyLedger { get; set; }
        public PetShop Shop { get; set; }

        public MonthlyLedgerManager(PetShop petshop)
        {
            Shop = petshop;  
        }

        // Methods

        public void  MonthlyLedgerGenerator()
        {
            monthLegList.Add(new MonthlyLedger(_date.Year, _date.Month, Shop));
        }

        public void CurrentMonthlyLedgerChanger()
        {
            currentMonthlyLedger = monthLegList[^1];
        }

        public void GeneratorActivator()
        {
            if(_date.Day == 1){
                MonthlyLedgerGenerator();
                CurrentMonthlyLedgerChanger();
            }
            else { }
        }

        public decimal? CurrentMonthTotal()
        {
            GeneratorActivator();
            currentMonthlyLedger.TotalCalc();
            decimal? currentMonthTotal = currentMonthlyLedger.Total; 
            return currentMonthTotal;
        }





    }
}

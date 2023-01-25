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
            GeneratorActivator();

        }

        // Methods

        public void  MonthlyLedgerGenerator()
        {
            monthLegList.Add(new MonthlyLedger(_date.Year, _date.Month, Shop));
            CurrentMonthlyLedgerChanger();
        }

        public void CurrentMonthlyLedgerChanger()
        {
            currentMonthlyLedger = monthLegList[^1];
        }

        public void GeneratorActivator()
        {
            if (currentMonthlyLedger == null)
            {
                MonthlyLedgerGenerator();
            }
            else {
                if (_date.Day == 1)
                {
                    MonthlyLedgerGenerator();
                }
                else { }
            }
        }

        public decimal? CurrentMonthTotal()
        {
            GeneratorActivator();
            currentMonthlyLedger.MothlyTotalCalc();
            decimal? currentMonthTotal = currentMonthlyLedger.Total; 
            return currentMonthTotal;
        }
        public decimal? CurrentMonthOverAllTotal()
        {
            GeneratorActivator();
            currentMonthlyLedger.OverAllTotalCalc();
            decimal? currentMonthOverAllTotal = currentMonthlyLedger.OverAllTotal;
            return currentMonthOverAllTotal;
        }





    }
}

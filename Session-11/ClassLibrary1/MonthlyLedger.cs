using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class MonthlyLedger
    {
        public DateTime Year { get; set; }
        public DateTime Month { get; set; }
        public decimal? Incomee { get; set; }
        public decimal? Expense { get; set; } 

        public decimal? Total { get; set; }

        public MonthlyLedger()
        {
            Expense += 2000;
        }

        public void incomeCalc()
        {
            PetShop shop= new PetShop();
            foreach (var item in shop.Transactions)
            {
                Expense += item.TotalPrice;
            }
        }
    }
}

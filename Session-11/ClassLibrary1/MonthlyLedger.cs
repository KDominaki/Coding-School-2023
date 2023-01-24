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
        public void expenseCalc()
        {
            PetShop shop = new PetShop();
            foreach (var food in shop.Foods)
            {
                Expense += food.Cost;
            }
            foreach (var pet in shop.Pets)
            {
                Expense += pet.Cost;
            }
        }
        public void totalCalc()
        {
            Total = Incomee - Expense;
        }
    }
}

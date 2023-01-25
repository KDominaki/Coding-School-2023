using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class MonthlyLedger
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public decimal? Incomee { get; set; }
        public decimal? Expense { get; set; } 
        public decimal? Total { get; set; }
        public decimal? OverAllTotal { get; set; }
        public decimal? OverAllIncomee { get; set; }
        public decimal? OverAllExpense { get; set; }
        public PetShop Petshop { get; set; }

        public List<Transaction> MonthlyTransactions = new List<Transaction>();

        public MonthlyLedger(int year, int month,PetShop petshop)
        {
            Petshop= petshop;
            Year = year;
            Month = month;
            Expense += 2000;
        }

        public void IncomeCalc()
        {
            foreach (var item in MonthlyTransactions)
            {
                Incomee += item.TotalPrice;
            }
        }

        public void TotalIncomeCalc()
        {
            foreach (var item in Petshop.Transactions)
            {
                Incomee += item.TotalPrice;
            }
        }
        public void ExpenseCalc() // Πρέπει να υπάρχει λίστα με τις αγορές του μαγαζιού αυτού του μήνα
        {
            
        //    foreach (var food in Petshop.MonthlyPets)
        //    {
        //        Expense += food.Cost;
        //    }
        //    foreach (var pet in Petshop.MonthlyFoods)
        //    {
        //        Expense += pet.Cost;
        //    }
        //    foreach (var employee in Petshop.Employees)
        //    {
        //        Expense += employee.SalaryPerMonth;
        //    }
        }

        public void TotalExpenseCalc() // Περιμένουμε τις συνολικές αγορές του μαγαζιού
        {
            foreach (var food in Petshop.Pets)
            {
                Expense += food.Cost;
            }
            foreach (var pet in Petshop.Foods)
            {
                Expense += pet.Cost;
            }
            foreach (var employee in Petshop.Employees)
            {
                Expense += employee.SalaryPerMonth;
            }
        }

        public void GetMonthsTrans()
        {

            foreach (var trans in Petshop.Transactions)
            {
                if (trans.Date.Year == Year && trans.Date.Month == Month)
                {
                    MonthlyTransactions.Add(trans);
                }
                else { }

            }
        }

        public decimal? TotalCalc()
        {
            GetMonthsTrans();
            ExpenseCalc();
            IncomeCalc();
            Total = Incomee - Expense;
            return Total;
        }


        public decimal? OverAllTotalCalc()
        {
            TotalExpenseCalc();
            TotalIncomeCalc();
            OverAllTotal = Incomee - Expense;
            return OverAllTotal;
        }

    }
}

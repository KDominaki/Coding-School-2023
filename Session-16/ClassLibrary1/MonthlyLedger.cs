using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        public List<PetFood> MonthlyPetfoodTransactions= new List<PetFood>();
        public List<Pet>MontlhyPetTransactions= new List<Pet>();

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
        public void MonthlyExpenseCalc()
        {

                foreach (var food in MonthlyPetfoodTransactions)
                {
                    Expense += food.Cost;
                }
                foreach (var pet in MontlhyPetTransactions)
                {
                    Expense += pet.Cost;
                }
                foreach (var employee in Petshop.Employees)
                {
                    Expense += employee.SalaryPerMonth;
                }
        }

        public void TotalExpenseCalc() 
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
            foreach (var food in Petshop.Foods)
            {
                foreach (var trans in food.PetFoodTransactions)
                {
                    if(trans.Date.Year == Year && trans.Date.Month == Month) 
                    { 
                        MonthlyPetfoodTransactions.Add(food);
                    }
                }
            }
            foreach (var pet in Petshop.Pets)
            {
                if (pet.Bought.Year == Year && pet.Bought.Month == Month)
                {
                    MontlhyPetTransactions.Add(pet);
                }


            }
        }

        public void MothlyTotalCalc()
        {
            GetMonthsTrans();
            MonthlyExpenseCalc();
            IncomeCalc();
            Total = Incomee - Expense;
           
        }


        public void OverAllTotalCalc()
        {
            TotalExpenseCalc();
            TotalIncomeCalc();
            OverAllTotal = Incomee - Expense;

        }

    }
}

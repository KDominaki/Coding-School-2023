using CarServiceCenter.EF.Repositories;
using CarServiceCenter.Model;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Contracts;

namespace CarServiceCenter.Web.Blazor.Server.Controllers
{
    public class MonthlyLedgerController : Controller
    {
        private readonly IEntityRepo<Transaction> _transactionRepo;
        private readonly IEntityRepo<Manager> _managerRepo;
        private readonly IEntityRepo<Engineer> _engineerRepo;
        
        public MonthlyLedgerController(IEntityRepo<Transaction> transanctionRepo,
                                        IEntityRepo<Manager> managerRepo,
                                        IEntityRepo<Engineer> engineerRepo)
        {
            _transactionRepo = transanctionRepo;
            _managerRepo = managerRepo;
            _engineerRepo = engineerRepo;
        }

        [HttpGet]
        public ActionResult MonthlyLedger()
        {
            var monthlyLedgers = List<MonthlyLedgerDto>();
            var transactions = _engineerRepo.GetAll().ToList();
            var managers = _managerRepo.GetAll().ToList();
            var engineers = _engineerRepo.GetAll().ToList();

            MonthlyLedgerDto = new MonthlyLedgerDto();
            decimal totalTransactions = 0;
            decimal totalSalaryEngineers = 0;
            decimal totalSalaryManagers = 0;
            foreach ( var transaction in transactions )
            {
                totalTransactions += transaction.TotalPrice;
            }
            foreach(var mangager in managers)
            {
                totalSalaryManagers += Manager.SalaryPerMonth;
            }
            foreach(var engineer in engineers)
            {
                totalSalaryEngineers += Engineer.SalaryPerMonth;
            }
            var groupedTransactions = transactions.GroupBy(transactions => { transactions.Date.Year, trans.Date.Month})
                .Select(grouped => new MonthlyLedger
                {
                    Year = grouped.Key.Year,
                    Month = grouped.Key.Month,
                    Income = grouped.Sum(transactions => transactions.totalTransactions),
                    Expenses = grouped.totalSalaryManagers + grouped.totalSalaryEngineers,
                    Total = grouped.Income - grouped.Expenses
                });
            monthlyLedgers.Add(MonthlyLedger);
            return View (groupedTransactions);
        }   
    }
}

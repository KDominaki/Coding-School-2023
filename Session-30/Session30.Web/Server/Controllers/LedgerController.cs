using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Session30.EF.Repositories;
using Session30.Models;
using Session30.Web.Client.Pages.Employee;
using Session30.Web.Shared;
using System.Net.WebSockets;

namespace Session30.Web.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class LedgerController : ControllerBase
    {
        private readonly IEntityRepo<Transaction> _transactionRepo;
        private readonly IEntityRepo<Employee> _employeeRepo;

        public LedgerController(IEntityRepo<Transaction> transactionRepo, IEntityRepo<Employee> employeeRepo)
        {
            _transactionRepo = transactionRepo;
            _employeeRepo = employeeRepo;
        }

        [HttpGet]
        public async Task<IEnumerable<Ledger>> Get()
        {
            int month = 0;
            int year = 0;
            var ledgers = new List<Ledger>();
            var transactions = _transactionRepo.GetAll();
            var employees = _employeeRepo.GetAll();
            foreach (var item in transactions)
            {
                if (item.Date.Month != month)
                {
                    month = item.Date.Month;
                    year = item.Date.Year;
                    Ledger newLedger = new Ledger(month, year);
                    newLedger.TotalCalc(transactions, employees);
                    ledgers.Add(newLedger);

                }


            }
            return ledgers; 
        }

      
    }
}

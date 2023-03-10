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
        private readonly IEntityRepo<Rent> _rentRepo;

        public LedgerController(IEntityRepo<Transaction> transactionRepo, IEntityRepo<Employee> employeeRepo, IEntityRepo<Rent> rentRepo)
        {
            _transactionRepo = transactionRepo;
            _employeeRepo = employeeRepo;
            _rentRepo = rentRepo;
        }

        [HttpGet]
        public async Task<IEnumerable<Ledger>> Get()
        {
            int month = 0;
            int year = 0;
            var ledgers = new List<Ledger>();
            var transactions = _transactionRepo.GetAll();
            var employees = _employeeRepo.GetAll();
            var rent = _rentRepo.GetById(1);
            foreach (var item in transactions)
            {
                if (item.Date.Month != month)
                {
                    month = item.Date.Month;
                    year = item.Date.Year;
                    Ledger newLedger = new Ledger(month, year);
                    newLedger.Rent = rent;
                    newLedger.TotalCalc(transactions, employees);
                    ledgers.Add(newLedger);
                }
                if (item.Date.Month == month && item.Date.Year != year)
                {
                    month = item.Date.Month;
                    year = item.Date.Year;
                    Ledger newLedger = new Ledger(month, year);
                    newLedger.Rent = rent;
                    newLedger.TotalCalc(transactions, employees);
                    ledgers.Add(newLedger);
                }


            }
            return ledgers; 
        }
		
        [HttpGet("{Id}")]
		public async Task<Rent> GetById(int id)
		{
			var result = _rentRepo.GetById(id);
			return new Rent
			{
				Id = id,
				Price = result.Price

			};
		}

		[HttpPut]
        public async Task Put(Rent rent)
        {
            var itemToUpdate = _rentRepo.GetById(rent.Id);

            itemToUpdate.Price = rent.Price;
            _rentRepo.Update(rent.Id, itemToUpdate);
        }


    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Session30.EF.Repositories;
using Session30.Models;
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
        public async Task<IEnumerable<Transaction>> GetTrans()
        {
            var result = _transactionRepo.GetAll();
            return result; 
        }

        [HttpGet]
        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            var result =  _employeeRepo.GetAll();
            return result;
        }
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Session30.EF.Repositories;
using Session30.Models;
using Session30.Web.Shared;

namespace Session30.Web.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        private readonly IEntityRepo<Transaction> _transactionRepo;

        public TransactionController(IEntityRepo<Transaction> transactionRepo)
        {
            _transactionRepo = transactionRepo;
        }
        [HttpGet]
        public async Task<IEnumerable<TransactionListDto>> Get()
        {
            var result = _transactionRepo.GetAll();
            return result.Select(transaction => new TransactionListDto
            {
                Id = transaction.Id,
                Date = transaction.Date,
                TotalValue = transaction.TotalValue,
                PaymentMethod = transaction.PaymentMethod,
            });
        }
    }
}

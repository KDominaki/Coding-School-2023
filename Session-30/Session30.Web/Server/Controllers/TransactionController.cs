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

        [HttpGet("{Id}")]
        public async Task<TransactionEditDto> GetById(int id)
        {
            var result = _transactionRepo.GetById(id);
            return new TransactionEditDto
            {
                Id = id,
                Date = result.Date,
                PaymentMethod = result.PaymentMethod,
                TotalValue= result.TotalValue,

            };
        }

        [HttpPost]
        public async Task Post(TransactionEditDto trans)
        {
            var newTransaction = new Transaction()
            {
                Date = trans.Date,
                TotalValue = trans.TotalValue,
                PaymentMethod = trans.PaymentMethod,

            };
            _transactionRepo.Add(newTransaction);
        }

        [HttpPut]
        public async Task Put(TransactionEditDto trans)
        {
            var itemToUpdate = _transactionRepo.GetById(trans.Id);

            itemToUpdate.Date = trans.Date;
            itemToUpdate.PaymentMethod = trans.PaymentMethod;
            itemToUpdate.TotalValue = trans.TotalValue;
            _transactionRepo.Update(trans.Id, itemToUpdate);
        }

        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {

            _transactionRepo.Delete(id);
        }
    }
}

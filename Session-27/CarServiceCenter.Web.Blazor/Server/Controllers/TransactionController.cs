using CarServiceCenter.EF.Repositories;
using CarServiceCenter.Model;
using CarServiceCenter.Web.Blazor.Shared;
using CarServiceCenter.Web.Blazor.Shared.Transaction;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarServiceCenter.Web.Blazor.Server.Controllers {
    [Route("[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase {

        private readonly IEntityRepo<Transaction> _trasRepo;
        private readonly IEntityRepo<Car> _carRepo;
        private readonly IEntityRepo<Customer> _customerRepo;
        private readonly IEntityRepo<Manager> _managerRepo;
        private readonly IEntityRepo<TransactionLine> _trasLinesRepo;

        public TransactionController(IEntityRepo<Transaction> trasRepo, IEntityRepo<Car> carRepo, IEntityRepo<Customer> customerRepo,
                                      IEntityRepo<Manager> managerRepo, IEntityRepo<TransactionLine> transactionlineRepo) {

            _trasRepo = trasRepo;
            _carRepo = carRepo;
            _customerRepo = customerRepo;
            _managerRepo = managerRepo;
            _trasLinesRepo = transactionlineRepo;

        }


        [HttpGet]
        public async Task<IEnumerable<TransactionListDto>> Get() {
            var result = _trasRepo.GetAll();
            return result.Select(tras => new TransactionListDto {
                Id = tras.Id,
                Date= tras.Date,
                TotalPrice= tras.TotalPrice,
                CustomerId= tras.CustomerId,              
                ManagerId= tras.ManagerId,
            
                CarId= tras.CarId,
               
            });
        }

        [HttpGet("{id}")]
        public async Task<TransactionEditDto> GetById(int id) {
            var result = _trasRepo.GetById(id);
            return new TransactionEditDto {
                Id = id,
                Date=result.Date,
                TotalPrice= result.TotalPrice,
                CustomerId= result.CustomerId,
              
                ManagerId= result.ManagerId,
          
                CarId= result.CarId,
      
            };
        }

        [HttpPost]
        public async Task Post(TransactionEditDto transaction) {
            var newTras = new Transaction() {

                Id = transaction.Id,
                Date = transaction.Date,
                TotalPrice = transaction.TotalPrice,
                CustomerId = transaction.CustomerId,
               
                ManagerId = transaction.ManagerId,
           
                CarId = transaction.CarId,
              
                TransactionLines= transaction.TransactionLines
            };
            _trasRepo.Add(newTras);
        }

        [HttpPut]
        public async Task Put(TransactionEditDto tras) {
            var itemToUpdate = _trasRepo.GetById(tras.Id);


            itemToUpdate.TotalPrice= tras.TotalPrice;
            itemToUpdate.CustomerId = tras.CustomerId;
            itemToUpdate.ManagerId = tras.ManagerId;
            itemToUpdate.CarId = tras.CarId;
      
        
         
            itemToUpdate.Date= tras.Date;
            itemToUpdate.TransactionLines = tras.TransactionLines;

            _trasRepo.Update(tras.Id, itemToUpdate);
        }

        [HttpDelete("{id}")]
        public async Task Delete(int id) {
            _trasRepo.Delete(id);
        }

    }

}


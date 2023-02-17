using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CarServiceCenter.EF.Repositories;
using CarServiceCenter.Model;
using CarServiceCenter.Web.Blazor.Shared.TransactionLine;
using CarServiceCenter.Web.Blazor.Shared.ServiceTask;
using CarServiceCenter.Web.Blazor.Shared;
using CarServiceCenter.Web.Blazor.Shared.Transaction;

namespace CarServiceCenter.Web.Blazor.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TransactionLineController : ControllerBase
    {
        private readonly IEntityRepo<Transaction> _transactionRepo;
        private readonly IEntityRepo<TransactionLine> _transactionLineRepo;
        private readonly IEntityRepo<Customer> _customerRepo;
        private readonly IEntityRepo<Manager> _managerRepo;
        private readonly IEntityRepo<Car> _carRepo;
        private readonly IEntityRepo<ServiceTask> _serviceTaskRepo;
        private readonly IEntityRepo<Engineer> _engineerRepo;

        public TransactionLineController(IEntityRepo<TransactionLine> transactionLineRepo, IEntityRepo<Transaction> transactionRepo, IEntityRepo<Customer> customerRepo, IEntityRepo<Manager> managerRepo, IEntityRepo<Car> carRepo, IEntityRepo<ServiceTask> serviceTaskRepo, IEntityRepo<Engineer> engineerRepo) {

            _transactionRepo = transactionRepo;
            _customerRepo = customerRepo;
            _managerRepo = managerRepo;
            _carRepo = carRepo;
            _serviceTaskRepo = serviceTaskRepo;
            _engineerRepo = engineerRepo;
            _transactionLineRepo = transactionLineRepo;
        }

        [HttpGet]
        public IEnumerable<TransactionLineListDto> Get()
        {
            var transanctionLines = _transactionLineRepo.GetAll();
            return transanctionLines.Select(transanctionLine => new TransactionLineListDto
            {
                Id= transanctionLine.Id,
                Hours = transanctionLine.Hours,
                PricePerHour = transanctionLine.PricePerHour,
                TransactionId = transanctionLine.TransactionId,
                ServiceTaskId = transanctionLine.ServiceTaskId,
                EngineerId = transanctionLine.EngineerId
                //ServiceTaskCode = transanctionLine.ServiceTask.Code,
                //EngineerSurname = transanctionLine.Engineer.Surname
            });
        }

        [HttpGet("{id}")]
        public TransactionLineEditDto GetById(int id) {
            var transactionLine = _transactionLineRepo.GetById(id);
            var transactions = _transactionRepo.GetAll();
            var serviceTasks = _serviceTaskRepo.GetAll();
            var engineers = _engineerRepo.GetAll();
            return new TransactionLineEditDto {
                Id = transactionLine.Id,
                Hours = transactionLine.Hours,
                PricePerHour = transactionLine.PricePerHour,
                TransactionId = transactionLine.TransactionId,
                ServiceTaskId = transactionLine.ServiceTaskId,
                EngineerId = transactionLine.EngineerId,

                Transactions = transactions.Select(transaction => new TransactionListDto {
                    Id = transaction.Id
                }).ToList(),

                ServiceTasks = serviceTasks.Select(servicetask => new ServiceTaskListDto {
                    Id = servicetask.Id,
                    Code = servicetask.Code,
                    Description = servicetask.Description,
                    Hours = servicetask.Hours
                }).ToList(),

                Engineers = engineers.Select(engineer => new EngineerListDto {
                    Id = engineer.Id,
                    Name = engineer.Name,
                    Surname = engineer.Surname,
                    SalaryPerMonth= engineer.SalaryPerMonth
                }).ToList()
            };
        }


        [HttpPost]
        public async Task Post(TransactionLineEditDto transactionLine) {
            //transactionLine.PricePerHour = 44.5m;
            var newTransactionLine = new TransactionLine(transactionLine.Hours, transactionLine.PricePerHour, transactionLine.Price);
            newTransactionLine.TransactionId = transactionLine.TransactionId;
            newTransactionLine.ServiceTaskId = transactionLine.ServiceTaskId;
            newTransactionLine.EngineerId = transactionLine.EngineerId;
            _transactionLineRepo.Add(newTransactionLine);

            
        }

        [HttpPut]
        public async Task Put(TransactionLineEditDto transactionLine) {
            var transactionLineToUpdate = _transactionLineRepo.GetById(transactionLine.Id);

            transactionLineToUpdate.Hours = transactionLineToUpdate.Hours;
            transactionLineToUpdate.PricePerHour = transactionLineToUpdate.PricePerHour;
            transactionLineToUpdate.Price = transactionLineToUpdate.Price;
            transactionLineToUpdate.TransactionId = transactionLineToUpdate.TransactionId;
            transactionLineToUpdate.ServiceTaskId = transactionLineToUpdate.ServiceTaskId;
            transactionLineToUpdate.EngineerId = transactionLineToUpdate.EngineerId;
            _transactionLineRepo.Update(transactionLine.Id, transactionLineToUpdate);
        }


        [HttpDelete("{id}")]
        public void Delete(int id) {
            _transactionLineRepo.Delete(id);
        }
    }
}

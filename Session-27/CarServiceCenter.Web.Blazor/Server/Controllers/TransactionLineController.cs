using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CarServiceCenter.EF.Repositories;
using CarServiceCenter.Model;
using CarServiceCenter.Web.Blazor.Shared.TransactionLine;
using CarServiceCenter.Web.Blazor.Shared.ServiceTask;

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
                //ServiceTaskCode = transanctionLine.ServiceTask.Code,
                //EngineerSurname = transanctionLine.Engineer.Surname
            });
        }

        [HttpGet("{id}")]
        public TransactionLineEditDto GetById(int id)
        {
            var transactionLine = _transactionLineRepo.GetById(id);
            var serviceTask = _serviceTaskRepo.GetAll();
            var engineer = _engineerRepo.GetAll();
            return new TransactionLineEditDto
            {
                Id = transactionLine.Id,
                Hours = transactionLine.Hours,
                PricePerHour = transactionLine.PricePerHour,
                //ServiceTaskId = transactionLine.ServiceTaskId
            };
        }
    }
}

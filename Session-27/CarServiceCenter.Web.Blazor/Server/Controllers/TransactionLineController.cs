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
        private readonly IEntityRepo<TransactionLine> _transanctionLineRepo;
        private readonly IEntityRepo<Engineer> _engineerRepo;
        private readonly IEntityRepo<ServiceTask> _serviceTaskRepo;
        
        public TransactionLineController(IEntityRepo<TransactionLine> transactionLineRepo, IEntityRepo<Engineer> engineerRepo, IEntityRepo<ServiceTask> serviceTaskRepo)
        {
            _transanctionLineRepo= transactionLineRepo;
            _engineerRepo= engineerRepo;
            _serviceTaskRepo= serviceTaskRepo;
        }

        [HttpGet]
        public IEnumerable<TransactionLineListDto> Get()
        {
            var transanctionLines = _transanctionLineRepo.GetAll();
            return transanctionLines.Select(transanctionLine => new TransactionLineListDto
            {
                Id= transanctionLine.Id,
                Hours = transanctionLine.Hours,
                PricePerHour = transanctionLine.PricePerHour,
                ServiceTaskCode = transanctionLine.ServiceTask.Code,
                EngineerSurname = transanctionLine.Engineer.Surname
            });
        }

        [HttpGet("{id}")]
        public TransactionLineEditDto GetById(int id)
        {
            var transactionLine = _transanctionLineRepo.GetById(id);
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

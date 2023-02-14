using CarServiceCenter.EF.Repositories;
using CarServiceCenter.Model;
using CarServiceCenter.Web.Blazor.Shared.Customer;
using CarServiceCenter.Web.Blazor.Shared.ServiceTask;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace CarServiceCenter.Web.Blazor.Server.Controllers {
    [Route("[controller]")]
    [ApiController]
    public class ServiceTaskController : ControllerBase {
        private readonly IEntityRepo<ServiceTask> _serviceTaskRepo;

        public ServiceTaskController(IEntityRepo<ServiceTask> serviceTaskRepo) {
            _serviceTaskRepo = serviceTaskRepo; 
        }

        [HttpGet]
        public async Task<IEnumerable<ServiceTaskListDto>> Get() {
            var result = _serviceTaskRepo.GetAll();
            return result.Select(serviceTask => new ServiceTaskListDto {
                Id = serviceTask.Id,
                Code = serviceTask.Code,
                Description = serviceTask.Description,
                Hours = serviceTask.Hours
            });
        }

        [HttpGet("{id}")]
        public async Task<ServiceTaskEditDto> GetById(int id) {
            var result = _serviceTaskRepo.GetById(id);
            return new ServiceTaskEditDto {
                Id = id,
                Code = result.Code,
                Description = result.Description,
                Hours = result.Hours
            };
        }

        [HttpPost]
        public async Task Post(ServiceTaskEditDto serviceTask) {
            var newServiceTask = new ServiceTask(serviceTask.Code, serviceTask.Description, serviceTask.Hours);
            _serviceTaskRepo.Add(newServiceTask);
        }

        [HttpPut]
        public async Task Put(ServiceTaskEditDto serviceTask) {
            var itemToUpdate = _serviceTaskRepo.GetById(serviceTask.Id);
            itemToUpdate.Code = serviceTask.Code;
            itemToUpdate.Description = serviceTask.Description;
            itemToUpdate.Hours = serviceTask.Hours;
            _serviceTaskRepo.Update(serviceTask.Id, itemToUpdate);
        }

        [HttpDelete("{id}")]
        public async Task Delete(int id) {
            _serviceTaskRepo.Delete(id);
        }
    }
}

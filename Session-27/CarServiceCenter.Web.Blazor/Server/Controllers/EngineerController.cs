using CarServiceCenter.EF.Repositories;
using CarServiceCenter.Model;
using CarServiceCenter.Web.Blazor.Shared.Customer;
using CarServiceCenter.Web.Blazor.Shared.Engineer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace CarServiceCenter.Web.Blazor.Server.Controllers {
    [Route("a[controller]")]
    [ApiController]
    public class EngineerController : ControllerBase {

        private IEntityRepo<Engineer> _engineerRepo;

        public EngineerController(IEntityRepo<Engineer> engineerRepo) {
            _engineerRepo = engineerRepo;
        }

        [HttpGet]
        public async Task<IEnumerable<EngineerListDto>> Get() {
            var result = _engineerRepo.GetAll();
            return result.Select(engineer => new EngineerListDto {
                Id = engineer.Id,
                Name = engineer.Name,
                Surname = engineer.Surname,
                SalaryPerMonth = engineer.SalaryPerMonth,
                ManagerId = engineer.ManagerId,

            });
        }


        [HttpGet("{id}")]
        public async Task<EngineerEditDto> GetById(int id) {
            var result = _engineerRepo.GetById(id);
            return new EngineerEditDto {
                Id = id,
                Name = result.Name,
                Surname = result.Surname,
                ManagerId = result.ManagerId,
                SalaryPerMonth = result.SalaryPerMonth
            };
        }


        [HttpPost]
        public async Task Post(EngineerEditDto engineer) {
            var newEngineer = new Engineer(engineer.Name, engineer.Surname, engineer.SalaryPerMonth);
            newEngineer.ManagerId = engineer.ManagerId;
            _engineerRepo.Add(newEngineer);
        }

        [HttpPut]
        public async Task Put(EngineerEditDto engineer) {
            var itemToUpdate = _engineerRepo.GetById(engineer.Id);
            if (itemToUpdate == null) {
                throw new Exception("This engineer with {id} id doesnt exists");
            }
            itemToUpdate.Name = engineer.Name;
            itemToUpdate.Surname = engineer.Surname;
            itemToUpdate.SalaryPerMonth = engineer.SalaryPerMonth;
            itemToUpdate.ManagerId = engineer.ManagerId;
            _engineerRepo.Update(engineer.Id, itemToUpdate);
        }


        [HttpDelete("{id}")]
        public async Task Delete(int id) {
            _engineerRepo.Delete(id);
        }

    }


}

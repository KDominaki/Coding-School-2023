
using CarServiceCenter.EF.Repositories;
using CarServiceCenter.Model;
using CarServiceCenter.Web.Blazor.Shared;
using Microsoft.AspNetCore.Mvc;


namespace CarServiceCenter.Web.Blazor.Server.Controllers {
    [Route("[controller]")]
    [ApiController]
    public class EngineerController : ControllerBase {

        private readonly IEntityRepo<Engineer> _engineerRepo;
        private readonly IEntityRepo<Manager> _managerRepo;

        public EngineerController(IEntityRepo<Engineer> engineerRepo,IEntityRepo<Manager> managerRepo) {
            _managerRepo= managerRepo;
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

            var managers=_managerRepo.GetAll();
            return new EngineerEditDto {
                
                Name = result.Name,
                Surname = result.Surname,
                SalaryPerMonth = result.SalaryPerMonth,
                ManagerId = result.ManagerId,
                Managers = managers.Select(manager => new ManagerEditDto{
                    Id = manager.Id,
                    Name= manager.Name,
                    Surname= manager.Surname
                }).ToList()
            };
                
            }
    


        [HttpPost]
        public async Task Post(EngineerEditDto engineer) {
            var newEngineer = new Engineer(engineer.Name, engineer.Surname, engineer.SalaryPerMonth);
            if (engineer.ManagerId == 0) {
                //TODO
            } else {
                newEngineer.ManagerId = engineer.ManagerId;
            }
            _engineerRepo.Add(newEngineer);
        }

        [HttpPut]
        public async Task Put(EngineerEditDto engineer) {
            var itemToUpdate = _engineerRepo.GetById(engineer.Id);
            
            itemToUpdate.Name= engineer.Name;
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

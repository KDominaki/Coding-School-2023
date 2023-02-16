
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
        //public async Task<IEnumerable<EngineerListDto>> Get() {
        public IEnumerable<EngineerListDto> Get() {
            var engineers = _engineerRepo.GetAll();
            return engineers.Select(engineer => new EngineerListDto {
                Id = engineer.Id,
                Name = engineer.Name,
                Surname = engineer.Surname,
                SalaryPerMonth = engineer.SalaryPerMonth,
                //ManagerId = engineer.ManagerId,
                ManagerSurname = engineer.Manager.Surname,
            });  
        }


        [HttpGet("{id}")]
        //public async Task<EngineerEditDto> GetById(int id) {
        public EngineerEditDto GetById(int id) {
            var engineer = _engineerRepo.GetById(id);
            var managers=_managerRepo.GetAll();
            return new EngineerEditDto {
                Id = engineer.Id,   
                Name = engineer.Name,
                Surname = engineer.Surname,
                SalaryPerMonth = engineer.SalaryPerMonth,
                ManagerId = engineer.ManagerId,

                Managers = managers.Select(manager => new ManagerListDto{
                    Id = manager.Id,
                    Name= manager.Name,
                    Surname= manager.Surname
                }).ToList()
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
            var engineerToUpdate = _engineerRepo.GetById(engineer.Id);
            
            engineerToUpdate.Name= engineer.Name;
            engineerToUpdate.Surname = engineer.Surname;
            engineerToUpdate.SalaryPerMonth = engineer.SalaryPerMonth;
            engineerToUpdate.ManagerId = engineer.ManagerId;
            _engineerRepo.Update(engineer.Id, engineerToUpdate);
        }


        [HttpDelete("{id}")]
        public void Delete(int id) {
            _engineerRepo.Delete(id);
        }
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Session30.EF.Repositories;
using Session30.Models;
using Session30.Web.Shared;

namespace Session30.Web.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEntityRepo<Employee> _employeeRepo;
        public EmployeeController(IEntityRepo<Employee> employeeRepo)
        {
            _employeeRepo = employeeRepo;
        }

        [HttpGet]
        public async Task<IEnumerable<EmployeeListDto>> Get()
        {
            var result = _employeeRepo.GetAll();
            return result.Select(employee => new EmployeeListDto
            {
                Id = employee.Id,
                Name = employee.Name,
                Surname = employee.Surname,
                SallaryPerMonth = employee.SallaryPerMonth,
                HireDateEnd= employee.HireDateEnd,
                HireDateStart= employee.HireDateStart,
                EmployeeType = employee.EmployeeType,
            });
        }

        [HttpGet("{Id}")]
        public async Task<EmployeeEditDto> GetById(int id)
        {
            var result = _employeeRepo.GetById(id);
            return new EmployeeEditDto
            {
                Id = id,
                Name = result.Name,
                Surname = result.Surname,
                SallaryPerMonth = result.SallaryPerMonth,
                HireDateEnd = result.HireDateEnd,
                HireDateStart = result.HireDateStart,
                EmployeeType = result.EmployeeType,

            };
        }

        [HttpPost]
        public async Task Post(EmployeeEditDto employee)
        {
            var newEmployee = new Employee()
            {
                Name = employee.Name,
                Surname = employee.Surname,
                SallaryPerMonth = employee.SallaryPerMonth,
                HireDateEnd = employee.HireDateEnd,
                HireDateStart = employee.HireDateStart,
                EmployeeType = employee.EmployeeType,
            };
            _employeeRepo.Add(newEmployee);
        }

        [HttpPut]
        public async Task Put(EmployeeEditDto employee)
        {
            var itemToUpdate = _employeeRepo.GetById(employee.Id);

            itemToUpdate.Name = employee.Name;
            itemToUpdate.Surname = employee.Surname;
            itemToUpdate.SallaryPerMonth = employee.SallaryPerMonth;
            itemToUpdate.HireDateEnd = employee.HireDateEnd;
            itemToUpdate.EmployeeType = employee.EmployeeType;
            itemToUpdate.HireDateStart = employee.HireDateStart;
            _employeeRepo.Update(employee.Id, itemToUpdate);
        }

        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {

            _employeeRepo.Delete(id);
        }
    }
}


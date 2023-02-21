using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Session30.EF.Repositories;
using Session30.Models;
using Session30.Web.Shared;

namespace Session30.Web.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IEntityRepo<Customer> _customerRepo;
        public CustomerController(IEntityRepo<Customer> customerRepo)
        {
            _customerRepo= customerRepo;
        }

        [HttpGet]
        public async Task<IEnumerable<CustomerListDto>> Get()
        {
            var result = _customerRepo.GetAll();
            return result.Select(customer => new CustomerListDto
            {
                Id= customer.Id,
                Name = customer.Name,
                Surname= customer.Surname,
                CardNumber= customer.CardNumber,
            });
        }

        [HttpGet("{Id}")]
        public async Task<CustomerEditDto> GetById(int id)
        {
            var result = _customerRepo.GetById(id);
            return new CustomerEditDto
            {
                Id = id,
                Name = result.Name,
                Surname = result.Surname,
                
            };
        }

        [HttpPost]
        public async Task Post(CustomerEditDto customer)
        {
            var newCustomer = new Customer()
            {
                Name = customer.Name,
                Surname= customer.Surname,
            };
            _customerRepo.Add(newCustomer);
        }

        [HttpPut]
        public async Task Put(CustomerEditDto customer)
        {
            var itemToUpdate = _customerRepo.GetById(customer.Id);

            itemToUpdate.Name = customer.Name;
            itemToUpdate.Surname = customer.Surname;
            _customerRepo.Update(customer.Id, itemToUpdate);
        }

        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {

            _customerRepo.Delete(id);
        }
    }

}

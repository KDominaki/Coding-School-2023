using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigurationsLibrary.Repositories
{
    public class CustomerRepo : IEntityRepo<Customer>
    {
        public void Add(Customer entity)
        {
            using var context = new AppDbContext();
        }

        public void Delete(Guid id)
        {
            using var context = new AppDbContext();
        }

        public IList<Customer> GetAll()
        {
            using var context = new AppDbContext();
            return context.Customers.ToList();

        }

        public Customer? GetById(Guid id)
        {
            using var context = new AppDbContext();
            return context.Customers.Where(employee => employee.ID == id).SingleOrDefault();
        }

        public void Update(Guid id, Customer entity)
        {
            using var context = new AppDbContext();
        }
    }
}

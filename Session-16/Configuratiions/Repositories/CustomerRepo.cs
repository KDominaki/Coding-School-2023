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
            context.Add(entity);
            context.SaveChanges();
        }

        public void Delete(Guid id)
        {
            using var context = new AppDbContext();
            var dbCustomer = context.Customers.Where(customer => customer.ID == id).SingleOrDefault();
            if (dbCustomer is null)
            {
                return;
            }
            else
            {
                context.Remove(dbCustomer);
                context.SaveChanges();
            }
                
            
        }

        public IList<Customer> GetAll()
        {
            using var context = new AppDbContext();
            return context.Customers.ToList();

        }

        public Customer? GetById(Guid id)
        {
            using var context = new AppDbContext();
            return context.Customers.Where(customer => customer.ID == id).SingleOrDefault();
        }

        public void Update(Guid id, Customer entity)
        {
            using var context = new AppDbContext();
            var dbCustomer = context.Customers.Where(customer => customer.ID == id).SingleOrDefault();
            if (dbCustomer is null)
            {
                return;
            }
            else
            {
                dbCustomer.TIN = entity.TIN;
                dbCustomer.Phone = entity.Phone;
                dbCustomer.Name = entity.Name;
                dbCustomer.Surname = entity.Surname;
                context.SaveChanges();
            }
        }
    }
}

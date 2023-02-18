using Session30.EF.Context;
using Session30.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session30.EF.Repositories
{
    public class CustomerRepo : IEntityRepo<Customer>
    {
        public void Add(Customer entity)
        {
            using var context = new AppDbContext();
            if (entity.Id != 0)
            {
                throw new ArgumentException("Given entity should not have Id set", nameof(entity));
            }
            context.Customers.Add(entity);
            context.SaveChanges();

        }

        public void Delete(int id)
        {
            using var context = new AppDbContext();
            var dbCustomer = context.Customers.SingleOrDefault(Customer => Customer.Id == id);
            if (dbCustomer is null)
            {
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");
            }
            context.Customers.Remove(dbCustomer);
            context.SaveChanges();
        }

        public IList<Customer> GetAll()
        {
            using var context = new AppDbContext();
            return context.Customers.ToList();
        }

        public Customer? GetById(int id)
        {
            using var context = new AppDbContext();
            return context.Customers.SingleOrDefault(Customer => Customer.Id == id);
        }

        public void Update(int id, Customer entity)
        {
            using var context = new AppDbContext();
            var dbCustomer = context.Customers.SingleOrDefault(Customer => Customer.Id == id);
            if (dbCustomer is null)
            {
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");
            }
            dbCustomer.Surname = entity.Surname;
            dbCustomer.Name = entity.Name;
            dbCustomer.CardNumber = entity.CardNumber;
            context.SaveChanges();
        }
    }
}

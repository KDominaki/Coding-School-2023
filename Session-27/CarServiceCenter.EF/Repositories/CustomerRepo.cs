using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using CarServiceCenter.EF.Context;
using CarServiceCenter.Model;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace CarServiceCenter.EF.Repositories
{
    public class CustomerRepo : IEntityRepo<Customer>
    {
        public void Add(Customer entity)
        {
            using var context = new CarServiceCenterDbContext();
            if (entity.Id != 0)
            { 
                throw new ArgumentException("Given entity should not have Id set", nameof(entity)); 
            }
           context.Customers.Add(entity);
           context.SaveChanges();

        }

        public void Delete(int id)
        {
            using var context = new CarServiceCenterDbContext();
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
          using var context = new CarServiceCenterDbContext();
          return context.Customers.ToList();
        }

        public Customer? GetById(int id)
        {
           using var context = new CarServiceCenterDbContext();
            return context.Customers.SingleOrDefault(Customer => Customer.Id == id);
        }

        public void Update(int id, Customer entity)
        {
            using var context = new CarServiceCenterDbContext(); 
            var dbCustomer = context.Customers.SingleOrDefault(Customer => Customer.Id ==id);
            if (dbCustomer is null )
            {
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");
            }
            dbCustomer.Surname = entity.Surname;
            dbCustomer.Name = entity.Name;
            dbCustomer.Phone =  entity.Phone;
            dbCustomer.Tin =entity.Tin;
            context.SaveChanges();
        }
    }
}

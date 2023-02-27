using Session30.EF.Context;
using Session30.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session30.EF.Repositories
{
    public class RentRepo : IEntityRepo<Rent>
    {
        public void Add(Rent entity)
        {
            using var context = new AppDbContext();
            if (entity.Id != 0)
            {
                throw new ArgumentException("Given entity should not have Id set", nameof(entity));
            }
            context.Rents.Add(entity);
            context.SaveChanges();

        }
        public void Delete(int id)
        {
            using var context = new AppDbContext();
            var dbRent = context.Rents.SingleOrDefault(Rent => Rent.Id == id);
            if (dbRent is null)
            {
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");
            }
            context.Rents.Remove(dbRent);
            context.SaveChanges();
        }
        public IList<Rent> GetAll()
        {
            using var context = new AppDbContext();
            return context.Rents.ToList();
        }

        public Rent? GetById(int id)
        {
            using var context = new AppDbContext();
            return context.Rents.SingleOrDefault(Rent => Rent.Id == id);
        }

        public void Update(int id, Rent entity)
        {
            using var context = new AppDbContext();
            var dbRent = context.Rents.SingleOrDefault(Rent => Rent.Id == id);
            if (dbRent is null)
            {
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");
            }
            dbRent.Price = entity.Price;
            context.SaveChanges();
        }
    }
}

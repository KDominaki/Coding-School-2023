using CarServiceCenter.EF.Context;
using CarServiceCenter.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceCenter.EF.Repositories
{
    public class TransactionRepo : IEntityRepo<Transaction>
    {
        public void Add(Transaction entity)
        {
            using var context = new CarServiceCenterDbContext();
            if (entity.Id != 0)
            {
                throw new ArgumentException("Given entity should not have Id set", nameof(entity));
            }
           
            context.Add(entity);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            using var context = new CarServiceCenterDbContext();
            var dbTransaction = context.Transactions.Where(transaction => transaction.Id == id).Include(transaction => transaction.Customer)
                .Include(transaction => transaction.Manager).Include(transaction => transaction.Car).SingleOrDefault();
            if (dbTransaction is null)
            {
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");
            }
            context.Remove(dbTransaction);
            context.SaveChanges();
        }

        public IList<Transaction> GetAll()
        {
            using var context = new CarServiceCenterDbContext();
            return context.Transactions.Include(transaction => transaction.Customer)
                .Include(transaction => transaction.Manager).Include(transaction => transaction.Car).ToList();
        }

        public Transaction? GetById(int id)
        {
            using var context = new CarServiceCenterDbContext();
            return context.Transactions.Where(transaction => transaction.Id == id).Include(transaction => transaction.Customer)
                .Include(transaction => transaction.Manager).Include(tras=>tras.TransactionLines).Include(transaction => transaction.Car).SingleOrDefault();
        }

        public void Update(int id, Transaction entity)
        {
            using var context = new CarServiceCenterDbContext();
            var dbTransaction = context.Transactions.Where(transaction => transaction.Id == id).Include(transaction => transaction.Customer)
                .Include(transaction => transaction.Manager).Include(transaction => transaction.Car).SingleOrDefault();
            if (dbTransaction is null)
            {
                
              throw new KeyNotFoundException($"Given id '{id}' was not found in database");
               
            }
            dbTransaction.Date = entity.Date;
            dbTransaction.TotalPrice = entity.TotalPrice;
            dbTransaction.CustomerId = entity.CustomerId;
            dbTransaction.ManagerId = entity.ManagerId;
            dbTransaction.CarId = entity.CarId;
            context.SaveChanges();
        }
    }
}

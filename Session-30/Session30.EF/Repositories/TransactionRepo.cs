using Session30.EF.Context;
using Session30.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session30.EF.Repositories
{
    public class TransactionRepo : IEntityRepo<Transaction>
    {
        public void Add(Transaction entity)
        {
            using var context = new AppDbContext();
            if (entity.Id != 0)
            {
                throw new ArgumentException("Given entity should not have Id set", nameof(entity));
            }
            context.Transactions.Add(entity);
            context.SaveChanges();

        }

        public void Delete(int id)
        {
            using var context = new AppDbContext();
            var dbTransaction = context.Transactions.SingleOrDefault(Transaction => Transaction.Id == id);
            if (dbTransaction is null)
            {
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");
            }
            context.Transactions.Remove(dbTransaction);
            context.SaveChanges();
        }

        public IList<Transaction> GetAll()
        {
            using var context = new AppDbContext();
            return context.Transactions.ToList();
        }

        public Transaction? GetById(int id)
        {
            using var context = new AppDbContext();
            return context.Transactions.SingleOrDefault(Transaction => Transaction.Id == id);
        }

        public void Update(int id, Transaction entity)
        {
            using var context = new AppDbContext();
            var dbTransaction = context.Transactions.SingleOrDefault(Transaction => Transaction.Id == id);
            if (dbTransaction is null)
            {
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");
            }
            dbTransaction.Date = entity.Date;
            dbTransaction.EmployeeId = entity.EmployeeId;
            dbTransaction.CustomerId = entity.CustomerId;
            dbTransaction.PaymentMethod = entity.PaymentMethod;
            dbTransaction.TotalValue = entity.TotalValue;

            context.SaveChanges();
        }
    }
}

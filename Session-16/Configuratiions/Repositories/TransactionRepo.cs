using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigurationsLibrary.Repositories
{
    public class TransactionRepo : IEntityRepo<Transaction>
    {
        public void Add(Transaction entity)
        {
            using var context = new AppDbContext();
            context.Add(entity);
            context.SaveChanges();
        }

        public void Delete(Guid id)
        {
            using var context = new AppDbContext();
            var dbTransaction = context.Transactions.Where(transaction => transaction.ID == id).SingleOrDefault();
            if (dbTransaction is null)
            {
                return;
            }
            else
            {
                context.Remove(dbTransaction);
                context.SaveChanges();
            }
        }

        public IList<Transaction> GetAll()
        {
            using var context = new AppDbContext();
            return context.Transactions.ToList();
        }

        public Transaction? GetById(Guid id)
        {
            using var context = new AppDbContext();
            return context.Transactions.Where(transaction => transaction.ID == id).SingleOrDefault();
        }

        public void Update(Guid id, Transaction entity)
        {
            using var context = new AppDbContext();
            var dbTransaction = context.Transactions.Where(transaction => transaction.ID == id).SingleOrDefault();
            if (dbTransaction is null)
            {
                return;
            }
            else
            {
                dbTransaction.TotalPrice = entity.TotalPrice;
                dbTransaction.PetPrice = entity.PetPrice;
                dbTransaction.PetFoodPrice = entity.PetFoodPrice;
                dbTransaction.Date = entity.Date;
                dbTransaction.PetFoodQty = entity.PetFoodQty;
                context.SaveChanges();
            }
        }
    }
}

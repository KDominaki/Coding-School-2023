
using PetShop.EF.Context;
using PetShop.EF.Repos;
using PetShop.Model;
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
            using var context = new PetShopDbContext();
            context.Add(entity);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            using var context = new PetShopDbContext();
            var dbTransaction = context.Transactions.Where(transaction => transaction.Id == id).SingleOrDefault();
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
            using var context = new PetShopDbContext();
            return context.Transactions.ToList();
        }

        public Transaction? GetById(int id)
        {
            using var context = new PetShopDbContext();
            return context.Transactions.Where(transaction => transaction.Id == id).SingleOrDefault();
        }

        public void Update(int id, Transaction entity)
        {
            using var context = new PetShopDbContext();
            var dbTransaction = context.Transactions.Where(transaction => transaction.Id == id).SingleOrDefault();
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
                dbTransaction.CustomerId = entity.CustomerId;
                dbTransaction.EmployeeId = entity.EmployeeId;
                dbTransaction.PetId = entity.PetId;
                dbTransaction.PetFoodId = entity.PetFoodId;
                dbTransaction.PetFoodQty = entity.PetFoodQty;
                context.SaveChanges();
            }
        }
    }
}

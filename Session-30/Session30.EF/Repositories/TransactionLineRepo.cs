using Session30.EF.Context;
using Session30.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session30.EF.Repositories
{
    public class TransactionLineRepo : IEntityRepo<TransactionLine>
    {
        public void Add(TransactionLine entity)
        {
            using var context = new AppDbContext();
            if (entity.Id != 0)
            {
                throw new ArgumentException("Given entity should not have Id set", nameof(entity));
            }
            context.TransactionLines.Add(entity);
            context.SaveChanges();

        }

        public void Delete(int id)
        {
            using var context = new AppDbContext();
            var dbTransactionLine = context.TransactionLines.SingleOrDefault(TransactionLine => TransactionLine.Id == id);
            if (dbTransactionLine is null)
            {
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");
            }
            context.TransactionLines.Remove(dbTransactionLine);
            context.SaveChanges();
        }

        public IList<TransactionLine> GetAll()
        {
            using var context = new AppDbContext();
            return context.TransactionLines.ToList();
        }

        public TransactionLine? GetById(int id)
        {
            using var context = new AppDbContext();
            return context.TransactionLines.SingleOrDefault(TransactionLine => TransactionLine.Id == id);
        }

        public void Update(int id, TransactionLine entity)
        {
            using var context = new AppDbContext();
            var dbTransactionLine = context.TransactionLines.SingleOrDefault(TransactionLine => TransactionLine.Id == id);
            if (dbTransactionLine is null)
            {
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");
            }
            dbTransactionLine.Quantity = entity.Quantity;
            dbTransactionLine.TransactionId = entity.TransactionId;
            dbTransactionLine.ItemId = entity.ItemId;
            dbTransactionLine.ItemPrice = entity.ItemPrice;
            dbTransactionLine.TotalValue = entity.TotalValue;
            dbTransactionLine.NetValue = entity.NetValue;
            dbTransactionLine.DiscountValue = entity.DiscountValue;
            dbTransactionLine.DiscountPercent = entity.DiscountPercent;

            context.SaveChanges();
        }
    }
}

using CarServiceCenter.EF.Context;
using CarServiceCenter.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceCenter.EF.Repositories
{
    public class TransactionLineRepo : IEntityRepo<TransactionLine>
    {
        public void Add(TransactionLine entity)
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
            var dbTransactionLine = context.TransactionLines.Where(transactionLine => transactionLine.Id == id).SingleOrDefault();
            if (dbTransactionLine is null)
            {
                return;
            }
            else
            {
                context.Remove(dbTransactionLine);
                context.SaveChanges();
            }
        }

        public IList<TransactionLine> GetAll()
        {
            using var context = new CarServiceCenterDbContext();
            return context.TransactionLines.ToList();
        }

        public TransactionLine? GetById(int id)
        {
            using var context = new CarServiceCenterDbContext();
            return context.TransactionLines.Where(transactionLine => transactionLine.Id == id).SingleOrDefault();
        }

        public void Update(int id, TransactionLine entity)
        {
            using var context = new CarServiceCenterDbContext();
            var dbTransactionLines = context.TransactionLines.Where(transactionLine => transactionLine.Id == id).SingleOrDefault();
            if (dbTransactionLines is null)
            {
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");
            }
            else
            {
                dbTransactionLines.Price = entity.Price;
                dbTransactionLines.PricePerHour = entity.PricePerHour;
                dbTransactionLines.Hours = entity.Hours;
                context.SaveChanges();
            }
        }
    }
}

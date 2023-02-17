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
            var dbTransactionLine = context.TransactionLines.Where(transactionLine => transactionLine.Id == id)
                .Include(transactionLine => transactionLine.Transaction)
                .Include(transactionLine => transactionLine.ServiceTask)
                .Include(transactionLine => transactionLine.Engineer).SingleOrDefault();
            if (dbTransactionLine is null)
            {
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");
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
            return context.TransactionLines.Include(transactionLine => transactionLine.Transaction)
                 .Include(transactionLine => transactionLine.ServiceTask)
                 .Include(transactionLine => transactionLine.Engineer).ToList();
        }

        public TransactionLine? GetById(int id)
        {
            using var context = new CarServiceCenterDbContext();
            return context.TransactionLines.Where(transactionLine => transactionLine.Id == id)
                 .Include(transactionLine => transactionLine.Transaction)
                 .Include(transactionLine => transactionLine.ServiceTask)
                 .Include(transactionLine => transactionLine.Engineer).SingleOrDefault();
        }

        public void Update(int id, TransactionLine entity)
        {
            using var context = new CarServiceCenterDbContext();
            var dbTransactionLines = context.TransactionLines.Where(transactionLine => transactionLine.Id == id)
                .Include(transactionLine => transactionLine.Transaction)
                .Include(transactionLine => transactionLine.ServiceTask)
                .Include(transactionLine => transactionLine.Engineer).SingleOrDefault();
            if (dbTransactionLines is null)
            {
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");
            }
            else
            {
                dbTransactionLines.Price = entity.Price;
                dbTransactionLines.PricePerHour = entity.PricePerHour;
                dbTransactionLines.Hours = entity.Hours;
                dbTransactionLines.TransactionId = entity.TransactionId;
                dbTransactionLines.ServiceTaskId = entity.ServiceTaskId;
                dbTransactionLines.EngineerId = entity.EngineerId;
                context.SaveChanges();
            }
        }
    }
}

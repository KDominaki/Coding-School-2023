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
        }

        public void Delete(Guid id)
        {
            using var context = new AppDbContext();
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
        }
    }
}

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
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public IList<Transaction> GetAll()
        {
            throw new NotImplementedException();
        }

        public Transaction? GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(Guid id, Transaction entity)
        {
            throw new NotImplementedException();
        }
    }
}

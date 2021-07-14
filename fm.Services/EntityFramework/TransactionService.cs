using fm.Interfaces.Services;
using fm.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace fm.Services.EntityFramework
{
    public class TransactionService : ITransactionService
    {
        public Task<bool> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<TransactionModel>> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Task<TransactionModel> GetById(long id)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<TransactionModel>> GetByName(string term)
        {
            throw new System.NotImplementedException();
        }

        public Task<TransactionModel> Insert(TransactionModel model)
        {
            throw new System.NotImplementedException();
        }

        public Task<TransactionModel> Update(TransactionModel model)
        {
            throw new System.NotImplementedException();
        }
    }
}

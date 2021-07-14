using fm.Interfaces.Services;
using fm.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace fm.Services.EntityFramework
{
    public class TransactionTypeService : ITransactionTypeService
    {
        public Task<bool> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<TransactionTypeModel>> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Task<TransactionTypeModel> GetById(long id)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<TransactionTypeModel>> GetByName(string term)
        {
            throw new System.NotImplementedException();
        }

        public Task<TransactionTypeModel> Insert(TransactionTypeModel model)
        {
            throw new System.NotImplementedException();
        }

        public Task<TransactionTypeModel> Update(TransactionTypeModel model)
        {
            throw new System.NotImplementedException();
        }
    }
}

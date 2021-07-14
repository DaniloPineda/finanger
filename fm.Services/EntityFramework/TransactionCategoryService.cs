using fm.Interfaces.Services;
using fm.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace fm.Services.EntityFramework
{
    public class TransactionCategoryService : ITransactionCategoryService
    {
        public Task<bool> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<TransactionCategoryModel>> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Task<TransactionCategoryModel> GetById(long id)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<TransactionCategoryModel>> GetByName(string term)
        {
            throw new System.NotImplementedException();
        }

        public Task<TransactionCategoryModel> Insert(TransactionCategoryModel model)
        {
            throw new System.NotImplementedException();
        }

        public Task<TransactionCategoryModel> Update(TransactionCategoryModel model)
        {
            throw new System.NotImplementedException();
        }
    }
}

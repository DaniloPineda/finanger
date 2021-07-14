using fm.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace fm.Interfaces.Services
{
    public interface ITransactionCategoryService
    {
        Task<IEnumerable<TransactionCategoryModel>> GetAll();
        Task<TransactionCategoryModel> GetById(long id);
        Task<IEnumerable<TransactionCategoryModel>> GetByName(string term);
        Task<TransactionCategoryModel> Insert(TransactionCategoryModel model);
        Task<TransactionCategoryModel> Update(TransactionCategoryModel model);
        Task<bool> Delete(long id);
    }
}

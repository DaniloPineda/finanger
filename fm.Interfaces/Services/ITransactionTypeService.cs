using fm.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace fm.Interfaces.Services
{
    public interface ITransactionTypeService
    {
        Task<IEnumerable<TransactionTypeModel>> GetAll();
        Task<TransactionTypeModel> GetById(long id);
        Task<IEnumerable<TransactionTypeModel>> GetByName(string term);
        Task<TransactionTypeModel> Insert(TransactionTypeModel model);
        Task<TransactionTypeModel> Update(TransactionTypeModel model);
        Task<bool> Delete(long id);
    }
}

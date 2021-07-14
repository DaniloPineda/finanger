using fm.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace fm.Interfaces.Services
{
    public interface ITransactionService
    {
        Task<IEnumerable<TransactionModel>> GetAll();
        Task<TransactionModel> GetById(long id);
        Task<IEnumerable<TransactionModel>> GetByName(string term);
        Task<TransactionModel> Insert(TransactionModel model);
        Task<TransactionModel> Update(TransactionModel model);
        Task<bool> Delete(long id);
    }
}

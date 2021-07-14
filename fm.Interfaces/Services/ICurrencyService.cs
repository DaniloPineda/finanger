using fm.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace fm.Interfaces.Services
{
    public interface ICurrencyService
    {
        Task<IEnumerable<CurrencyModel>> GetAll();
        Task<CurrencyModel> GetById(long id);
        Task<IEnumerable<CurrencyModel>> GetByName(string term);
        Task<CurrencyModel> Insert(CurrencyModel model);
        Task<CurrencyModel> Update(CurrencyModel model);
        Task<bool> Delete(long id);
    }
}

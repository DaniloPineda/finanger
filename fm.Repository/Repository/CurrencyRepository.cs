using fm.Data.EFModels;
using fm.Interfaces.Repositories;

namespace fm.Repository.Repository
{
    public class CurrencyRepository :BaseRepository<Currency>, ICurrencyRepository
    {
        public CurrencyRepository(FinangerContext context) : base(context)
        {
                
        }
    }
}

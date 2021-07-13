using fm.Interfaces.Repositories;
using fm.Services.EFModels;

namespace fm.Repository.Services
{
    public class TransactionRepository : BaseRepository<Transaction> , ITransactionRepository
    {
        public TransactionRepository(FinangerContext context) : base(context)
        {

        }
    }
}

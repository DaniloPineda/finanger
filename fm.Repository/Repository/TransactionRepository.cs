using fm.Data.EFModels;
using fm.Interfaces.Repositories;

namespace fm.Repository.Repository
{
    public class TransactionRepository : BaseRepository<Transaction> , ITransactionRepository
    {
        public TransactionRepository(FinangerContext context) : base(context)
        {

        }
    }
}

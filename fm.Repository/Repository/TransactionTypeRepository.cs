using fm.Data.EFModels;
using fm.Interfaces.Repositories;

namespace fm.Repository.Repository
{
    public class TransactionTypeRepository : BaseRepository<TransactionType>, ITransactionTypeRepository
    {
        public TransactionTypeRepository(FinangerContext context) : base(context) {

        }
    }
}

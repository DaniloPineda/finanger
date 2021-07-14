using fm.Data.EFModels;
using fm.Interfaces.Repositories;

namespace fm.Repository.Repository
{
    public class TransactionCategoryRepository: BaseRepository<TransactionCategory>, ITransactionCategoryRepository
    {
        public TransactionCategoryRepository(FinangerContext context) : base(context) {

        }
    }
}

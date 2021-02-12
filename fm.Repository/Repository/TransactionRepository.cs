using fm.Data;
using fm.Data.Models;
using fm.Interfaces.Repositories;

namespace fm.Repository.Services
{
    public class TransactionRepository : BaseRepository<Transaction> , ITransactionRepository
    {
        public TransactionRepository(FinangerContext context) : base(context)
        {

        }
    }
}

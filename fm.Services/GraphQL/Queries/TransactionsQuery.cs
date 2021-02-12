using fm.Interfaces.Repositories;
using fm.Services.GraphQL.Types;
using GraphQL.Types;

namespace fm.Services.GraphQL.Queries
{
    public class TransactionsQuery : ObjectGraphType
    {
        public TransactionsQuery(ITransactionRepository transactionRepository)
        {
            Field<ListGraphType<TransactionType>>(
                "transactions",
                resolve: context => transactionRepository.Get()
            );
        }
    }
}

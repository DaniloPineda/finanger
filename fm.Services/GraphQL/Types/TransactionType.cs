using fm.Data.Models;
using GraphQL.Types;

namespace fm.Services.GraphQL.Types
{
    public class TransactionType:ObjectGraphType<Transaction>
    {
        public TransactionType()
        {
            Field(t => t.TransactionId);
            Field(t => t.TransactionType);
            Field(t => t.Description);
            Field(t => t.Amount);
            Field(t => t.CreatedDate);            
        }

    }
}

using fm.Data.EFModels;
using GraphQL.Types;

namespace fm.Services.GraphQL.Types
{
    public class TransactionType:ObjectGraphType<Transaction>
    {
        public TransactionType()
        {
            Field(t => t.Id);
            Field(t => t.Type);
            Field(t => t.Description);
            Field(t => t.Amount);
            Field(t => t.Date);            
        }

    }
}

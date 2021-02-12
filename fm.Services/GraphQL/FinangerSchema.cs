using fm.Services.GraphQL.Queries;
using GraphQL;
using GraphQL.Types;


namespace fm.Services
{
    public class FinangerSchema :Schema
    {
        public FinangerSchema(IDependencyResolver resolver): base(resolver)
        {
            Query = resolver.Resolve<TransactionsQuery>();
        }
    }
}

using System.Collections.Generic;

namespace fm.Data.EFModels
{
    public partial class TransactionType
    {
        public TransactionType()
        {
            Transactions = new HashSet<Transaction>();
        }

        public long Id { get; set; }
        public string TypeName { get; set; }

        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}

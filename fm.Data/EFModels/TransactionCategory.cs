using System.Collections.Generic;

namespace fm.Data.EFModels
{
    public partial class TransactionCategory
    {
        public TransactionCategory()
        {
            Transactions = new HashSet<Transaction>();
        }

        public long Id { get; set; }
        public string CategoryName { get; set; }

        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}

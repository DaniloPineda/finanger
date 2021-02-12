using System;
using System.Collections.Generic;


namespace fm.Data.Models
{
    public partial class TransactionType
    {
        public TransactionType()
        {
            Transactions = new HashSet<Transaction>();
        }

        public long TransactionTypeId { get; set; }
        public string TransactionTypeName { get; set; }
        public bool IsDeleted { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public DateTimeOffset? DeletedDate { get; set; }

        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}

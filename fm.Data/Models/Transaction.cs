using System;

namespace fm.Data.Models
{
    public partial class Transaction
    {
        public long TransactionId { get; set; }
        public long TransactionTypeId { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public DateTimeOffset? UpdatedDate { get; set; }

        public virtual TransactionType TransactionType { get; set; }
    }
}

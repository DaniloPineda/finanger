using System;

namespace fm.Services.EFModels
{
    public partial class Transaction
    {
        public long Id { get; set; }
        public string TransactionName { get; set; }
        public string Description { get; set; }
        public long Type { get; set; }
        public long Category { get; set; }
        public decimal Amount { get; set; }
        public long Currency { get; set; }
        public DateTime Date { get; set; }

        public virtual TransactionCategory CategoryNavigation { get; set; }
        public virtual Currency CurrencyNavigation { get; set; }
        public virtual TransactionType TypeNavigation { get; set; }
    }
}

using System;

namespace fm.Models
{
    public class TransactionModel
    {
        public long Id { get; set; }
        public string TransactionName { get; set; }
        public string Description { get; set; }
        public long Type { get; set; }
        public long Category { get; set; }
        public decimal Amount { get; set; }
        public long Currency { get; set; }
        public DateTime Date { get; set; }
    }
}

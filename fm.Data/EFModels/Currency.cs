using System.Collections.Generic;

namespace fm.Services.EFModels
{
    public partial class Currency
    {
        public Currency()
        {
            Transactions = new HashSet<Transaction>();
        }

        public long Id { get; set; }
        public string CurrencyName { get; set; }

        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}

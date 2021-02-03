using System;

namespace fm.Web.Api.Models
{
    public partial class Portfolio
    {
        public long PortfolioId { get; set; }
        public long? CompanyId { get; set; }
        public string Description { get; set; }
        public decimal Ammount { get; set; }
        public bool IsActive { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public long CreatedBy { get; set; }

        public virtual Company Company { get; set; }
    }
}

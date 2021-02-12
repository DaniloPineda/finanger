using System;
using System.Collections.Generic;

namespace fm.Data.Models
{
    public partial class Company
    {
        public Company()
        {
            Portfolios = new HashSet<Portfolio>();
        }

        public long CompanyId { get; set; }
        public string CompanyName { get; set; }
        public long? DocumentTypeId { get; set; }
        public string DocumentNumber { get; set; }
        public string Address { get; set; }
        public bool IsDeleted { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public DateTimeOffset? DeletedDate { get; set; }

        public virtual DocumentType DocumentType { get; set; }
        public virtual ICollection<Portfolio> Portfolios { get; set; }
    }
}

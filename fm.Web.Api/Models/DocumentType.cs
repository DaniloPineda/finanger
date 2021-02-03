using System;
using System.Collections.Generic;

namespace fm.Web.Api.Models
{
    public partial class DocumentType
    {
        public DocumentType()
        {
            Companies = new HashSet<Company>();
            Users = new HashSet<User>();
        }

        public long DocTypeId { get; set; }
        public string DocTypeName { get; set; }
        public bool IsDeleted { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public DateTimeOffset? DeletedDate { get; set; }

        public virtual ICollection<Company> Companies { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}

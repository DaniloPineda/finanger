using System;


namespace fm.Data.Models
{
    public partial class UserCompany
    {
        public long UserId { get; set; }
        public long CompanyId { get; set; }
        public DateTimeOffset CreatedDate { get; set; }

        public virtual Company Company { get; set; }
        public virtual User User { get; set; }
    }
}

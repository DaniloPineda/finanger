using System;

namespace fm.Web.Api.Models
{
    public partial class Role
    {
        public long RoleId { get; set; }
        public string RoleName { get; set; }
        public bool IsDeleted { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public DateTimeOffset? DeletedDate { get; set; }
    }
}

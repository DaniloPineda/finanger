using System;

namespace fm.Data.Models
{
    public partial class User
    {
        public long UserId { get; set; }
        public string UserName { get; set; }
        public string UserLastName { get; set; }
        public DateTime BirthDate { get; set; }
        public long DocumentTypeId { get; set; }
        public string DocumentNumber { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public bool IsApproved { get; set; }
        public long PreferredLanguageId { get; set; }

        public virtual DocumentType DocumentType { get; set; }
        public virtual Language PreferredLanguage { get; set; }
    }
}

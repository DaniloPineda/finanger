using System;
using System.Collections.Generic;


namespace fm.Web.Api.Models
{
    public partial class Language
    {
        public Language()
        {
            Users = new HashSet<User>();
        }

        public long LanguageId { get; set; }
        public string LanguageName { get; set; }
        public DateTimeOffset CreatedDate { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}

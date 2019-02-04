using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterialHouse.Models
{
    public class Users
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Users()
        {
            this.Properties = new HashSet<Property>();
           this.Roles = new HashSet<Roles>();
        }

        public int Id { get; set; }
        public string Password { get; set; }
        public string PasswordSalt { get; set; }
        public Nullable<System.DateTime> PasswordUpdated { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string CompanyName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public Nullable<int> ZipCode { get; set; }
        public string BusinessPhone { get; set; }
        public string CompanyUrl { get; set; }
        public Nullable<System.DateTime> LastLoggedIn { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<System.DateTime> LastUpdated { get; set; }
        public int Blocked { get; set; }
        public string BlockedReason { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Property> Properties { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Roles> Roles { get; set; }


    }
}

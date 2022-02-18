using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SystraderContactRole
    {
        public SystraderContactRole()
        {
            PlsupplierContactRoles = new HashSet<PlsupplierContactRole>();
            SlcustomerContactRoles = new HashSet<SlcustomerContactRole>();
            SysdocumentTypes = new HashSet<SysdocumentType>();
        }

        public long SystraderContactRoleId { get; set; }
        public string Role { get; set; } = null!;
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public bool IsDefaultRole { get; set; }
        public bool? UseForCustomerAccounts { get; set; }
        public bool? UseForSupplierAccounts { get; set; }
        public bool IsMandatory { get; set; }
        public bool UseWithDocuments { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual ICollection<PlsupplierContactRole> PlsupplierContactRoles { get; set; }
        public virtual ICollection<SlcustomerContactRole> SlcustomerContactRoles { get; set; }
        public virtual ICollection<SysdocumentType> SysdocumentTypes { get; set; }
    }
}

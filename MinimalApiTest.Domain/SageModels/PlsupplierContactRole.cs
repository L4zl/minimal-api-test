using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PlsupplierContactRole
    {
        public long PlsupplierContactRoleId { get; set; }
        public long PlsupplierContactId { get; set; }
        public long SystraderContactRoleId { get; set; }
        public bool IsPreferredContactForRole { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual PlsupplierContact PlsupplierContact { get; set; } = null!;
        public virtual SystraderContactRole SystraderContactRole { get; set; } = null!;
    }
}

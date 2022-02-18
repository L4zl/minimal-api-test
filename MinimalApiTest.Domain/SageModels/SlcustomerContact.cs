using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SlcustomerContact
    {
        public SlcustomerContact()
        {
            SlcustomerContactRoles = new HashSet<SlcustomerContactRole>();
            SlcustomerContactValues = new HashSet<SlcustomerContactValue>();
        }

        public long SlcustomerContactId { get; set; }
        public long SlcustomerAccountId { get; set; }
        public string ContactName { get; set; } = null!;
        public string Description { get; set; } = null!;
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public long SlcustomerLocationId { get; set; }
        public long SalutationId { get; set; }
        public string FirstName { get; set; } = null!;
        public string MiddleName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string ContactNamePreMigratedData { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }

        public virtual Salutation Salutation { get; set; } = null!;
        public virtual SlcustomerAccount SlcustomerAccount { get; set; } = null!;
        public virtual SlcustomerLocation SlcustomerLocation { get; set; } = null!;
        public virtual ICollection<SlcustomerContactRole> SlcustomerContactRoles { get; set; }
        public virtual ICollection<SlcustomerContactValue> SlcustomerContactValues { get; set; }
    }
}

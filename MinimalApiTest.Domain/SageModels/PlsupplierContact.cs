using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PlsupplierContact
    {
        public PlsupplierContact()
        {
            PlsupplierContactRoles = new HashSet<PlsupplierContactRole>();
            PlsupplierContactValues = new HashSet<PlsupplierContactValue>();
        }

        public long PlsupplierContactId { get; set; }
        public long PlsupplierAccountId { get; set; }
        public string ContactName { get; set; } = null!;
        public string Description { get; set; } = null!;
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public long PlsupplierLocationId { get; set; }
        public long SalutationId { get; set; }
        public string FirstName { get; set; } = null!;
        public string MiddleName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string ContactNamePreMigratedData { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }

        public virtual PlsupplierAccount PlsupplierAccount { get; set; } = null!;
        public virtual PlsupplierLocation PlsupplierLocation { get; set; } = null!;
        public virtual Salutation Salutation { get; set; } = null!;
        public virtual ICollection<PlsupplierContactRole> PlsupplierContactRoles { get; set; }
        public virtual ICollection<PlsupplierContactValue> PlsupplierContactValues { get; set; }
    }
}

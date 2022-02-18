using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class Salutation
    {
        public Salutation()
        {
            PlsupplierContacts = new HashSet<PlsupplierContact>();
            SlcustomerContacts = new HashSet<SlcustomerContact>();
        }

        public long SalutationId { get; set; }
        public bool IsDefault { get; set; }
        public string Code { get; set; } = null!;
        public string Description { get; set; } = null!;
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public long SequenceNumber { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual ICollection<PlsupplierContact> PlsupplierContacts { get; set; }
        public virtual ICollection<SlcustomerContact> SlcustomerContacts { get; set; }
    }
}

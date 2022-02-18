using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SlcustomerContactValue
    {
        public SlcustomerContactValue()
        {
            SlcustomerDocuments = new HashSet<SlcustomerDocument>();
        }

        public long SlcustomerContactValueId { get; set; }
        public long SlcustomerContactId { get; set; }
        public long SyscontactTypeId { get; set; }
        public string ContactValue { get; set; } = null!;
        public bool IsPreferredValue { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public string ContactValueCountryCode { get; set; } = null!;
        public string ContactValueAreaCode { get; set; } = null!;
        public string ContactValueSubscriberNumber { get; set; } = null!;
        public string ContactValuePreMigratedData { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }

        public virtual SlcustomerContact SlcustomerContact { get; set; } = null!;
        public virtual SyscontactType SyscontactType { get; set; } = null!;
        public virtual ICollection<SlcustomerDocument> SlcustomerDocuments { get; set; }
    }
}

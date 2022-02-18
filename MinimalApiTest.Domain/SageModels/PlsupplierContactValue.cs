using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PlsupplierContactValue
    {
        public PlsupplierContactValue()
        {
            PlsupplierDocuments = new HashSet<PlsupplierDocument>();
        }

        public long PlsupplierContactValueId { get; set; }
        public long PlsupplierContactId { get; set; }
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

        public virtual PlsupplierContact PlsupplierContact { get; set; } = null!;
        public virtual SyscontactType SyscontactType { get; set; } = null!;
        public virtual ICollection<PlsupplierDocument> PlsupplierDocuments { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SysdocumentLayoutVersion
    {
        public SysdocumentLayoutVersion()
        {
            PlsupplierDocuments = new HashSet<PlsupplierDocument>();
            SlcustomerDocuments = new HashSet<SlcustomerDocument>();
            SlpendCustomerAccounts = new HashSet<SlpendCustomerAccount>();
        }

        public long SysdocumentLayoutVersionId { get; set; }
        public string Name { get; set; } = null!;
        public long? SysdocumentTypeId { get; set; }
        public string Layout { get; set; } = null!;
        public bool? IsDefault { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }

        public virtual SysdocumentType? SysdocumentType { get; set; }
        public virtual ICollection<PlsupplierDocument> PlsupplierDocuments { get; set; }
        public virtual ICollection<SlcustomerDocument> SlcustomerDocuments { get; set; }
        public virtual ICollection<SlpendCustomerAccount> SlpendCustomerAccounts { get; set; }
    }
}

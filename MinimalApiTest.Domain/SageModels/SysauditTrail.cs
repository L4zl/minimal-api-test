using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SysauditTrail
    {
        public SysauditTrail()
        {
            SysnominalAuditTrails = new HashSet<SysnominalAuditTrail>();
            SystaxAuditTrails = new HashSet<SystaxAuditTrail>();
        }

        public long SysauditTrailId { get; set; }
        public bool? AlreadyPrinted { get; set; }
        public bool TaxEntriesExist { get; set; }
        public bool NominalEntriesExist { get; set; }
        public string AccountNumber { get; set; } = null!;
        public string AccountName { get; set; } = null!;
        public long SysauditTrailEntryTypeId { get; set; }
        public string Reference { get; set; } = null!;
        public string SecondReference { get; set; } = null!;
        public string BatchReference { get; set; } = null!;
        public decimal TransactionToBaseExchangeRate { get; set; }
        public DateTime? TransactionDate { get; set; }
        public DateTime? PostedDate { get; set; }
        public string UserName { get; set; } = null!;
        public int UserNumber { get; set; }
        public long Source { get; set; }
        public long UniqueReferenceNumber { get; set; }
        public decimal NetValue { get; set; }
        public decimal DiscountValue { get; set; }
        public decimal TaxValue { get; set; }
        public decimal GrossValue { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual SysauditTrailEntryType SysauditTrailEntryType { get; set; } = null!;
        public virtual ICollection<SysnominalAuditTrail> SysnominalAuditTrails { get; set; }
        public virtual ICollection<SystaxAuditTrail> SystaxAuditTrails { get; set; }
    }
}

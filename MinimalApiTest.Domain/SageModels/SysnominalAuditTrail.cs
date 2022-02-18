using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SysnominalAuditTrail
    {
        public long SysnominalAuditTrailId { get; set; }
        public long SysauditTrailId { get; set; }
        public string AccountNumber { get; set; } = null!;
        public string CostCentre { get; set; } = null!;
        public string Department { get; set; } = null!;
        public string AccountName { get; set; } = null!;
        public bool NominalExistedAtPostTime { get; set; }
        public decimal NominalValue { get; set; }
        public string Narrative { get; set; } = null!;
        public string Reference { get; set; } = null!;
        public DateTime? TransactionDate { get; set; }
        public DateTime? PostedDate { get; set; }
        public int UserNumber { get; set; }
        public long Source { get; set; }
        public long UniqueReferenceNumber { get; set; }
        public string TradingNominalAnalysisCode { get; set; } = null!;
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual SysauditTrail SysauditTrail { get; set; } = null!;
    }
}

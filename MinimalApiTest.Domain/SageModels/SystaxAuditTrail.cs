using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SystaxAuditTrail
    {
        public long SystaxAuditTrailId { get; set; }
        public long SysauditTrailId { get; set; }
        public long SystaxRateId { get; set; }
        public decimal GoodsValue { get; set; }
        public decimal DiscountValue { get; set; }
        public decimal DiscountPercent { get; set; }
        public decimal TaxValue { get; set; }
        public string TransactionReference { get; set; } = null!;
        public DateTime? TransactionDate { get; set; }
        public DateTime? PostedDate { get; set; }
        public int UserNumber { get; set; }
        public long Source { get; set; }
        public long UniqueReferenceNumber { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual SysauditTrail SysauditTrail { get; set; } = null!;
        public virtual SystaxRate SystaxRate { get; set; } = null!;
    }
}

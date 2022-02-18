using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SystaxAdjustment
    {
        public long SystaxAdjustmentId { get; set; }
        public long SystaxPeriodId { get; set; }
        public short VatBoxNumber { get; set; }
        public decimal Amount { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public string Reason { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }

        public virtual SystaxPeriod SystaxPeriod { get; set; } = null!;
    }
}

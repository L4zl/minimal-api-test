using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class ValueDiscountBreak
    {
        public long ValueDiscountBreakId { get; set; }
        public decimal ValueMoreThan { get; set; }
        public decimal DiscountPercentValue { get; set; }
        public long OrderValueDiscountId { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual OrderValueDiscount OrderValueDiscount { get; set; } = null!;
    }
}

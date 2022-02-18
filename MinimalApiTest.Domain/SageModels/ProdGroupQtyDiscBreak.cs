using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class ProdGroupQtyDiscBreak
    {
        public long ProdGroupQtyDiscBreakId { get; set; }
        public decimal QuantityMoreThan { get; set; }
        public decimal DiscountPercentValue { get; set; }
        public long ProductGroupDiscountId { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual ProductGroupDiscount ProductGroupDiscount { get; set; } = null!;
    }
}

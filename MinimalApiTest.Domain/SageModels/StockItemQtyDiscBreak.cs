using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class StockItemQtyDiscBreak
    {
        public long StockItemQtyDiscBreakId { get; set; }
        public decimal QuantityMoreThan { get; set; }
        public decimal DiscountAmountValue { get; set; }
        public decimal DiscountPercentValue { get; set; }
        public long StockItemDiscountId { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual StockItemDiscount StockItemDiscount { get; set; } = null!;
    }
}

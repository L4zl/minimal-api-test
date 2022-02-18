using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class CustStockItemDiscount
    {
        public long CustStockItemDiscountId { get; set; }
        public long CustomerDiscountGroupId { get; set; }
        public long StockItemDiscountId { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual CustomerDiscountGroup CustomerDiscountGroup { get; set; } = null!;
        public virtual StockItemDiscount StockItemDiscount { get; set; } = null!;
    }
}

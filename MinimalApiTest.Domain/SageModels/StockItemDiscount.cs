using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class StockItemDiscount
    {
        public StockItemDiscount()
        {
            CustStockItemDiscounts = new HashSet<CustStockItemDiscount>();
            StockItemQtyDiscBreaks = new HashSet<StockItemQtyDiscBreak>();
        }

        public long StockItemDiscountId { get; set; }
        public string Name { get; set; } = null!;
        public long StockItemUnitId { get; set; }
        public long DiscountTypeId { get; set; }
        public long? CurrencyId { get; set; }
        public long? StockItemId { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual Syscurrency? Currency { get; set; }
        public virtual DiscountType DiscountType { get; set; } = null!;
        public virtual StockItem? StockItem { get; set; }
        public virtual StockItemUnit StockItemUnit { get; set; } = null!;
        public virtual ICollection<CustStockItemDiscount> CustStockItemDiscounts { get; set; }
        public virtual ICollection<StockItemQtyDiscBreak> StockItemQtyDiscBreaks { get; set; }
    }
}

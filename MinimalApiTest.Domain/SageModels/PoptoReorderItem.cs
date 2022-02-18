using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PoptoReorderItem
    {
        public PoptoReorderItem()
        {
            PoptoReorderWarehouses = new HashSet<PoptoReorderWarehouse>();
        }

        public long PoptoReorderItemId { get; set; }
        public long ItemId { get; set; }
        public string ItemCode { get; set; } = null!;
        public string ItemName { get; set; } = null!;
        public string StockUnit { get; set; } = null!;
        public decimal QuantityRequired { get; set; }
        public decimal QuantityConfirmed { get; set; }
        public decimal ConfirmedPurchaseValue { get; set; }
        public long ToReorderItemStatusId { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual StockItem Item { get; set; } = null!;
        public virtual PoptoReorderItemStatus ToReorderItemStatus { get; set; } = null!;
        public virtual ICollection<PoptoReorderWarehouse> PoptoReorderWarehouses { get; set; }
    }
}

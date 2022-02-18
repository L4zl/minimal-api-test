using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PoptoReorderWarehouse
    {
        public PoptoReorderWarehouse()
        {
            PoptoReorderSoplines = new HashSet<PoptoReorderSopline>();
        }

        public long PoptoReorderWarehouseId { get; set; }
        public long WarehouseItemId { get; set; }
        public decimal QuantityRequired { get; set; }
        public decimal QuantityToPurchase { get; set; }
        public decimal WarehouseReorderLevel { get; set; }
        public long SupplierId { get; set; }
        public decimal UnitPrice { get; set; }
        public bool Confirmed { get; set; }
        public bool ToNegotiate { get; set; }
        public long PoptoReorderItemId { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual PoptoReorderItem PoptoReorderItem { get; set; } = null!;
        public virtual PlsupplierAccount Supplier { get; set; } = null!;
        public virtual WarehouseItem WarehouseItem { get; set; } = null!;
        public virtual ICollection<PoptoReorderSopline> PoptoReorderSoplines { get; set; }
    }
}

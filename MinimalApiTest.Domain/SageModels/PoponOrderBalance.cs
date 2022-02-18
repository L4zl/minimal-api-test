using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PoponOrderBalance
    {
        public long PoponOrderBalanceId { get; set; }
        public decimal OnOrderQuantity { get; set; }
        public string SupplierReference { get; set; } = null!;
        public string SupplierName { get; set; } = null!;
        public string Reference { get; set; } = null!;
        public string SecondRef { get; set; } = null!;
        public DateTime OrderDate { get; set; }
        public long ItemId { get; set; }
        public long WarehouseItemId { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual WarehouseItem WarehouseItem { get; set; } = null!;
        public virtual PoponOrderLine PoponOrderLine { get; set; } = null!;
    }
}

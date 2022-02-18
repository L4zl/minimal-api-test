using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconReserveStockLine
    {
        public long SiconReserveStockLineId { get; set; }
        public long? SiconReserveStockId { get; set; }
        public long? ItemId { get; set; }
        public string ItemCode { get; set; } = null!;
        public string ItemName { get; set; } = null!;
        public long? WarehouseId { get; set; }
        public string WarehouseName { get; set; } = null!;
        public long? BinItemId { get; set; }
        public string BinName { get; set; } = null!;
        public long? AllocationId { get; set; }
        public DateTime? RequestedDate { get; set; }
        public decimal Quantity { get; set; }
        public decimal IssuedQuantity { get; set; }
        public int Status { get; set; }
        public string StatusEnumDescription { get; set; } = null!;
        public DateTime? LastUpdatedDate { get; set; }
        public string LastUpdatedBy { get; set; } = null!;
        public long? WarehouseItemId { get; set; }
        public decimal OriginalQuantity { get; set; }
    }
}

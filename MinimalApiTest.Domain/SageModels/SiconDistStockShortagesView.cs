using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDistStockShortagesView
    {
        public string Name { get; set; } = null!;
        public string Code { get; set; } = null!;
        public decimal TargetMinimumLevel { get; set; }
        public decimal? TargetQuantityInStock { get; set; }
        public decimal? TargetQuantityAllocated { get; set; }
        public decimal? TargetFreeStock { get; set; }
        public int? InTransit { get; set; }
        public long TargetWarehouseId { get; set; }
        public long ItemId { get; set; }
        public long TargetWarehouseItemId { get; set; }
    }
}

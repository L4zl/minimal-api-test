using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconKitCanPreallocateView
    {
        public string Code { get; set; } = null!;
        public long SiconKitLineId { get; set; }
        public string Reference { get; set; } = null!;
        public long? BinItemId { get; set; }
        public string? Status { get; set; }
        public decimal? Quantity { get; set; }
        public DateTime? DateRequired { get; set; }
        public string WarehouseName { get; set; } = null!;
        public long? WarehouseId { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconWabreplenishmentAllocDemandView
    {
        public string? StockItemCode { get; set; }
        public string SopdocumentNo { get; set; } = null!;
        public long? SoporderReturnLineId { get; set; }
        public DateTime? PromisedDeliveryDate { get; set; }
        public decimal AllocatedQuantity { get; set; }
        public long AllocationId { get; set; }
        public long? BinItemId { get; set; }
        public long ItemId { get; set; }
        public long WarehouseId { get; set; }
        public decimal? ReplenishmentDays { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconWabreplenishLine
    {
        public long SiconWabreplenishLineId { get; set; }
        public long SiconWabreplenishId { get; set; }
        public long ItemId { get; set; }
        public long WarehouseId { get; set; }
        public long WarehouseItemId { get; set; }
        public long ReplenishBinItemId { get; set; }
        public string ReplenishBinName { get; set; } = null!;
        public long BulkBinItemId { get; set; }
        public string BulkBinName { get; set; } = null!;
        public decimal QuantityRequired { get; set; }
        public decimal QuantityPicked { get; set; }
        public decimal QuantityReplenished { get; set; }
        public bool? IsComplete { get; set; }
        public string LastUpdatedByUserId { get; set; } = null!;
        public DateTime? LastUpdatedDateTime { get; set; }
    }
}

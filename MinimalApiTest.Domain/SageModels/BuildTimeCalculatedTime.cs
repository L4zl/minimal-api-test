using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class BuildTimeCalculatedTime
    {
        public long? ItemId { get; set; }
        public long? BomRecordId { get; set; }
        public long? WarehouseId { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? FreeStockAtMovement { get; set; }
        public decimal? Shortage { get; set; }
        public DateTime? NextPredictedAvailableDate { get; set; }
    }
}

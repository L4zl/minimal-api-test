using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDistStockWastage
    {
        public long? SiconDistStockWastageId { get; set; }
        public long? SiconDistStockWastageTypesId { get; set; }
        public long? ItemId { get; set; }
        public decimal? Quantity { get; set; }
        public long? WeightTypeId { get; set; }
        public string? LastUpdatedByUserId { get; set; }
        public DateTime? LastUpdatedDateTime { get; set; }
    }
}

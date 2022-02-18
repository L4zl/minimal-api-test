using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class BomAllocationConsolidatedComponentView
    {
        public long? BomAllocationId { get; set; }
        public long WopComponentLineTypeId { get; set; }
        public string ComponentLineTypeName { get; set; } = null!;
        public string StockCode { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string UnitOfMeasure { get; set; } = null!;
        public decimal? QuantityRequired { get; set; }
        public decimal? QuantityAllocated { get; set; }
        public decimal? QuantityShort { get; set; }
        public int IsMiscellaneousItem { get; set; }
        public bool AllowNegativeStock { get; set; }
        public bool IsSingleBatchItem { get; set; }
        public int IsBatchNumbered { get; set; }
        public int IsSerialNumbered { get; set; }
        public bool BuiltBoughtDefaultMake { get; set; }
        public long? BomitemTypeId { get; set; }
        public bool IsBomOnHold { get; set; }
        public int HasMatchingWarehouse { get; set; }
        public string? StockItemProperties { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiDistStockItemGroupAttr
    {
        public long SiDistStockItemGroupAttrId { get; set; }
        public long? SiDistStockItemGroupId { get; set; }
        public long? SiDistStockMatrixAttributeId { get; set; }
        public bool? Enabled { get; set; }
        public bool? GridX { get; set; }
        public bool? GridY { get; set; }
        public string? LastUpdatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
    }
}

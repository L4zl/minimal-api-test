using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiDistStockItemGroupAttrOpt
    {
        public long SiDistStockItemGroupAttrOptId { get; set; }
        public long? SiDistStockItemGroupAttrId { get; set; }
        public long? SiDistStockMatrixAttrOptionId { get; set; }
        public bool? Enabled { get; set; }
        public long? Sequence { get; set; }
        public string? LastUpdatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiDistStockItemGroupItemOpt
    {
        public long SiDistStockItemGroupItemOptId { get; set; }
        public long? SiDistStockItemGroupItemId { get; set; }
        public long? SiDistStockMatrixAttrOptionId { get; set; }
        public string? LastUpdatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiDistStockItemGroupItem
    {
        public long SiDistStockItemGroupItemId { get; set; }
        public long? SiDistStockItemGroupId { get; set; }
        public long? ItemId { get; set; }
        public string? ItemCode { get; set; }
        public string? LastUpdatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
    }
}

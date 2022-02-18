using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiMrpstockRunningBalanceView
    {
        public string Type { get; set; } = null!;
        public long? ItemId { get; set; }
        public long WarehouseItemId { get; set; }
        public string? Month { get; set; }
        public decimal? Qty { get; set; }
    }
}

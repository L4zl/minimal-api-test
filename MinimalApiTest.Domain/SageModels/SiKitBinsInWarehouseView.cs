using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiKitBinsInWarehouseView
    {
        public string BinName { get; set; } = null!;
        public long WarehouseId { get; set; }
    }
}

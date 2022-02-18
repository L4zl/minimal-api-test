using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconWabuserWarehouse
    {
        public long SiconWabuserWarehouseId { get; set; }
        public long SiconWabuserId { get; set; }
        public long WarehouseId { get; set; }
        public bool IsEnabled { get; set; }
        public bool IsDefault { get; set; }
    }
}

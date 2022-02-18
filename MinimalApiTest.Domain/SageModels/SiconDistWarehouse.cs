using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDistWarehouse
    {
        public long SiconDistWarehouseId { get; set; }
        public long WarehouseId { get; set; }
        public bool? ApplyLandedCosts { get; set; }
    }
}

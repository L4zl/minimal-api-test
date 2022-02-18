using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconMpoptionsWarehouse
    {
        public long SiconMpoptionsWarehouseId { get; set; }
        public long? WarehouseId { get; set; }
        public bool? UseWarehouse { get; set; }
        public long? UserNumber { get; set; }
    }
}

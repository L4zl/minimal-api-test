using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconWablabelInfoWarehouse
    {
        public long SiconWablabelInfoWarehouseId { get; set; }
        public long SiconWablabelInfoId { get; set; }
        public string? Override2011Path { get; set; }
        public string? Override2013Path { get; set; }
        public string? OverridePrinter { get; set; }
        public long WarehouseId { get; set; }
    }
}

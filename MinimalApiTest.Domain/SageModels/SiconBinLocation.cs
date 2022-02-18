using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconBinLocation
    {
        public long SiconBinLocationId { get; set; }
        public long? WarehouseItemId { get; set; }
        public long? ItemId { get; set; }
        public long? WarehouseId { get; set; }
        public string? BinName { get; set; }
    }
}

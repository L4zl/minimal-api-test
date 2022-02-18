using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDistCalcMinWarehouse
    {
        public long SiconDistCalcMinWarehouseId { get; set; }
        public long? WarehouseId { get; set; }
        public bool? Selected { get; set; }
        public string? LastUpdatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
    }
}

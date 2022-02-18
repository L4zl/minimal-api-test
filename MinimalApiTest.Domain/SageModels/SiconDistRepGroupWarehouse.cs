using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDistRepGroupWarehouse
    {
        public long SiconDistRepGroupWarehouseId { get; set; }
        public long SiconDistRepGroupId { get; set; }
        public long WarehouseId { get; set; }
        public string? LastUpdatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
    }
}

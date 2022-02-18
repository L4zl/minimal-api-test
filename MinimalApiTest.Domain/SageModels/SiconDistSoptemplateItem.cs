using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDistSoptemplateItem
    {
        public long SiconDistSoptemplateItemId { get; set; }
        public long SiconDistSoptemplateId { get; set; }
        public long ItemId { get; set; }
        public string? Code { get; set; }
        public string? Name { get; set; }
        public decimal? Quantity { get; set; }
        public long? WarehouseId { get; set; }
        public string? WarehouseName { get; set; }
        public string? Narrative { get; set; }
        public string? LastUpdatedByUserId { get; set; }
        public DateTime? LastUpdatedDateTime { get; set; }
    }
}

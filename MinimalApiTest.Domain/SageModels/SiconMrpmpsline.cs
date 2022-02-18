using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconMrpmpsline
    {
        public long SiconMrpmpslineId { get; set; }
        public long? ItemId { get; set; }
        public string? ItemCode { get; set; }
        public string? ItemName { get; set; }
        public long? WarehouseId { get; set; }
        public string? WarehouseName { get; set; }
        public decimal? Quantity { get; set; }
        public bool? Daily { get; set; }
        public string? DayOfWeek { get; set; }
        public int? DateOfMonth { get; set; }
        public string? LastUpdatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconMrpsalesOverLeadTime
    {
        public long SiconMrpsalesOverLeadTimeId { get; set; }
        public long? ItemId { get; set; }
        public string? Code { get; set; }
        public long? WarehouseId { get; set; }
        public int? LeadTimeDays { get; set; }
        public decimal? Quantity { get; set; }
        public string? LastUpdatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
    }
}

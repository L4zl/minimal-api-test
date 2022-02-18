using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconMrptraceableExpiryView
    {
        public long TraceableItemId { get; set; }
        public long ItemId { get; set; }
        public string IdentificationNo { get; set; } = null!;
        public DateTime? SellByDate { get; set; }
        public DateTime? UseByDate { get; set; }
        public decimal? Quantity { get; set; }
        public long SupplierId { get; set; }
        public int LeadTime { get; set; }
        public long? WarehouseItemId { get; set; }
        public string WarehouseName { get; set; } = null!;
    }
}

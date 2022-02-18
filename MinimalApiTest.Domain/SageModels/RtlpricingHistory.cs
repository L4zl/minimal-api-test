using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class RtlpricingHistory
    {
        public long PricingHistId { get; set; }
        public long? PricingDefAllId { get; set; }
        public long PrdHierNodeId { get; set; }
        public long? ParentPrdHierNodeId { get; set; }
        public string StockItemCode { get; set; } = null!;
        public string SupplierCode { get; set; } = null!;
        public decimal? Cost { get; set; }
        public decimal? Margin { get; set; }
        public decimal? Markup { get; set; }
        public decimal? Price { get; set; }
        public DateTime? CreateDate { get; set; }
        public string PriceBand { get; set; } = null!;
        public decimal LandedCosts { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public long? PriceBandId { get; set; }
        public DateTime DateTimeUpdated { get; set; }
    }
}

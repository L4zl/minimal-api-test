using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDistSopsuperseded
    {
        public long SiconDistSopsupersededId { get; set; }
        public long? StockItem { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? SellingPrice { get; set; }
        public string? Warehouse { get; set; }
        public string? Status { get; set; }
        public long? SoporderReturn { get; set; }
        public string? LastUpdatedByUser { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
    }
}

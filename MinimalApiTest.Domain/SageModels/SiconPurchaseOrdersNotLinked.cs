using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconPurchaseOrdersNotLinked
    {
        public long? WarehouseId { get; set; }
        public long? ItemId { get; set; }
        public string Type { get; set; } = null!;
        public string? DocumentStatus { get; set; }
        public DateTime? DateRequired { get; set; }
        public decimal? Quantity { get; set; }
        public string? DocumentNo { get; set; }
        public long? LineId { get; set; }
        public decimal? Price { get; set; }
        public DateTime? DateRequiredRequestedFirst { get; set; }
        public decimal? Woquantity { get; set; }
        public decimal? WoquantityAllocated { get; set; }
        public decimal? WoquantityIssued { get; set; }
    }
}

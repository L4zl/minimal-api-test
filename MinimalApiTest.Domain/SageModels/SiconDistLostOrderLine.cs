using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDistLostOrderLine
    {
        public long SiconDistLostOrderLineId { get; set; }
        public long? CustomerId { get; set; }
        public long? SoporderLineId { get; set; }
        public DateTime? Date { get; set; }
        public long? StockItemId { get; set; }
        public long? WarehouseId { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? SellPrice { get; set; }
        public decimal? CostPrice { get; set; }
        public decimal? Discount { get; set; }
        public string? Reason { get; set; }
        public string? AdditionalInformation { get; set; }
        public bool? Authorised { get; set; }
        public bool Deleted { get; set; }
        public string? LastUpdatedByUser { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
    }
}

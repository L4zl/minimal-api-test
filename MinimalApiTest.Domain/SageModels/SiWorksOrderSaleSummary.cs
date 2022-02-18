using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiWorksOrderSaleSummary
    {
        public long SiWorksOrderSaleSummaryId { get; set; }
        public long? SiWorksOrderId { get; set; }
        public long? SiWorksOrderLineId { get; set; }
        public string? ItemType { get; set; }
        public string? Item { get; set; }
        public decimal? Cost { get; set; }
        public decimal? Margin { get; set; }
        public decimal? SalesPrice { get; set; }
        public decimal? Discount { get; set; }
        public decimal? Increase { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? UnitTotal { get; set; }
        public decimal? SellingInSocurrency { get; set; }
        public decimal? CostInSocurrency { get; set; }
        public decimal? Total { get; set; }
        public bool? Deleted { get; set; }
        public DateTime? Updateddate { get; set; }
        public string? Updateduser { get; set; }
        public bool Converted { get; set; }
    }
}

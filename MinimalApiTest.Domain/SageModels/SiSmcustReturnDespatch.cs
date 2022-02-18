using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiSmcustReturnDespatch
    {
        public long SiSmcustReturnDespatchId { get; set; }
        public long SiSmcaseId { get; set; }
        public long SiSmcustReturnId { get; set; }
        public DateTime? DespatchDate { get; set; }
        public int? SourceType { get; set; }
        public long? SiconStockTransferItemId { get; set; }
        public long? SoporderReturnLineId { get; set; }
        public bool? Billable { get; set; }
        public long? RevenueSiJcTrnId { get; set; }
        public long? ItemId { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? InvoicedQuantity { get; set; }
        public int? BillingPlan { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiWorksOrderIssuedHistoryView
    {
        public long? RowNumber { get; set; }
        public long SiWorksOrderLineId { get; set; }
        public long? TransactionHistoryId { get; set; }
        public long ItemId { get; set; }
        public string Code { get; set; } = null!;
        public string? IdentificationNo { get; set; }
        public decimal? CostValue { get; set; }
        public decimal? Quantity { get; set; }
    }
}

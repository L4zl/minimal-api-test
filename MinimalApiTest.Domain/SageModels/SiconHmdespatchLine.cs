using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconHmdespatchLine
    {
        public long SiconHmdespatchLineId { get; set; }
        public long SiconHmdespatchId { get; set; }
        public long? SiconHmorderLineAssetsLineId { get; set; }
        public long? AssetsLineItemId { get; set; }
        public long? SiconHmorderLineStockIssueId { get; set; }
        public long? SiconHmorderLineChargeLineId { get; set; }
        public decimal QuantityDespatched { get; set; }
        public decimal QuantityToFollow { get; set; }
        public string? LastUpdatedByUserId { get; set; }
        public DateTime? LastUpdatedDateTime { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconKitDisassembleIssueLine
    {
        public long SiconKitDisassembleIssueLineId { get; set; }
        public long StockItemId { get; set; }
        public string? ItemSerialNumber { get; set; }
        public decimal Quantity { get; set; }
        public decimal CostValue { get; set; }
        public decimal CostPercentage { get; set; }
        public long SiconKitDisassembleIssueId { get; set; }
        public string LastUpdatedByUserId { get; set; } = null!;
        public DateTime LastUpdatedDateTime { get; set; }
        public long? BinItemId { get; set; }
    }
}

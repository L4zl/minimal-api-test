using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconKitDisassembleIssue
    {
        public long SiconKitDisassembleIssueId { get; set; }
        public long StockItemId { get; set; }
        public string? ItemSerialNumber { get; set; }
        public decimal QuantityIssued { get; set; }
        public long BinItemId { get; set; }
        public decimal CostPrice { get; set; }
        public string? Reference { get; set; }
        public long? SiconKit { get; set; }
        public long? SiconKitTemplate { get; set; }
        public string? Status { get; set; }
        public string LastUpdatedByUserId { get; set; } = null!;
        public DateTime LastUpdatedDateTime { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconKitIssueLine
    {
        public long SiconKitIssueLineId { get; set; }
        public long SiconKitLineId { get; set; }
        public decimal QuantityIssued { get; set; }
        public decimal? CostPrice { get; set; }
        public long? TransactionHistory { get; set; }
        public long? BinItemId { get; set; }

        public virtual SiconKitLine SiconKitLine { get; set; } = null!;
    }
}

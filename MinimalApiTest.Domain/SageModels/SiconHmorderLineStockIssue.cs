using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconHmorderLineStockIssue
    {
        public long SiconHmorderLineStockIssueId { get; set; }
        public long SiconHmorderLineStockAllocId { get; set; }
        public decimal? QuantityIssued { get; set; }
        public long? IssueTransactionHistoryId { get; set; }
        public decimal? IssueCost { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconApplicationsLedgerView
    {
        public long? Id { get; set; }
        public long? SiJcJobId { get; set; }
        public string TransType { get; set; } = null!;
        public int TransTypeInt { get; set; }
        public string? Ledger { get; set; }
        public string? Reference1 { get; set; }
        public string? Reference2 { get; set; }
        public DateTime? TransDate { get; set; }
        public string? TraderReference { get; set; }
        public decimal? Amount { get; set; }
        public decimal? Allocated { get; set; }
        public decimal? Outstanding { get; set; }
        public decimal? Discount { get; set; }
        public decimal? Retention { get; set; }
        public decimal? Net { get; set; }
        public decimal? OutstandingNet { get; set; }
        public int IsOutstanding { get; set; }
    }
}

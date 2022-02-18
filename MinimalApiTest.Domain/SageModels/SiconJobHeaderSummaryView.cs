using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconJobHeaderSummaryView
    {
        public long SiJcJobId { get; set; }
        public string? JobNumber { get; set; }
        public string? JobDescription { get; set; }
        public long? SiJcChdId { get; set; }
        public string? JobHeader { get; set; }
        public string? JobHeaderName { get; set; }
        public string CustomerAccountNumber { get; set; } = null!;
        public string CustomerAccountName { get; set; } = null!;
        public decimal AccountBalance { get; set; }
        public decimal AccountBalanceNet { get; set; }
        public decimal? BudgetAmount { get; set; }
        public decimal Committed { get; set; }
        public decimal Actual { get; set; }
    }
}

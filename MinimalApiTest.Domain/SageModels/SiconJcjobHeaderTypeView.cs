using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconJcjobHeaderTypeView
    {
        public string JobHeaderType { get; set; } = null!;
        public string? JobNumber { get; set; }
        public long? Sijcjobid { get; set; }
        public decimal? CommittedCost { get; set; }
        public decimal? ActualCost { get; set; }
        public decimal? TotalCost { get; set; }
        public decimal? CommittedRevenue { get; set; }
        public decimal? ActualRevenue { get; set; }
        public decimal? TotalRevenue { get; set; }
        public decimal? Margin { get; set; }
        public decimal MarginPc { get; set; }
    }
}

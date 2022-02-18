using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconWorksOrderSummaryView
    {
        public long SiWorksOrderId { get; set; }
        public DateTime? WodueDate { get; set; }
        public string? Wonumber { get; set; }
        public decimal? TotalLabour { get; set; }
        public decimal? TotalMachine { get; set; }
        public decimal? WoproductionLeadTime { get; set; }
    }
}

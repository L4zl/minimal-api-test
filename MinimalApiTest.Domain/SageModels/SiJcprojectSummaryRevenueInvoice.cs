using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiJcprojectSummaryRevenueInvoice
    {
        public long? Sijcjobid { get; set; }
        public string? Jobnumber { get; set; }
        public decimal? Committed { get; set; }
        public decimal? Actual { get; set; }
        public decimal? TotalCosts { get; set; }
        public DateTime? DateRange { get; set; }
    }
}

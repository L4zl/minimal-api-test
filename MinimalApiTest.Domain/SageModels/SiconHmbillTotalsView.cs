using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconHmbillTotalsView
    {
        public long? SiconHmorderId { get; set; }
        public string? HireOrderNumber { get; set; }
        public decimal? TotalInvoicedToDate { get; set; }
        public decimal? TotalRemainingToBeInvoiced { get; set; }
    }
}

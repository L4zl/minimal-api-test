using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconContractInvoiceTotalsView
    {
        public long SiconContractId { get; set; }
        public decimal? TotalInvoicedToDate { get; set; }
        public decimal? TotalRemainingToBeInvoiced { get; set; }
    }
}

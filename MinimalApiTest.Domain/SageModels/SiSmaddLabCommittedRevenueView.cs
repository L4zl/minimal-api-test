using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiSmaddLabCommittedRevenueView
    {
        public long SiSmcaseAdditionalLabourId { get; set; }
        public string? CaseNumber { get; set; }
        public decimal? Revenue { get; set; }
    }
}

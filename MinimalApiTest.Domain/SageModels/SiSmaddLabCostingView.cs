using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiSmaddLabCostingView
    {
        public long SiSmcaseAdditionalLabourId { get; set; }
        public string? CaseNumber { get; set; }
        public decimal? Cost { get; set; }
    }
}

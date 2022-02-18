using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconSfdcactualTime
    {
        public long? SiOperationId { get; set; }
        public int? ItemCount { get; set; }
        public decimal? Actual { get; set; }
        public int? Estimated { get; set; }
        public decimal? PercentComplete { get; set; }
        public string? CurrentTime { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconJcconstructionTransByRangeView
    {
        public long SiJcTrnId { get; set; }
        public long? SiJcJobId { get; set; }
        public decimal? RetentionValue { get; set; }
        public decimal? ApplicationValue { get; set; }
        public decimal? ValuationValue { get; set; }
        public DateTime? EndDate { get; set; }
    }
}

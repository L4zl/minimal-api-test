using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiCustomerRange
    {
        public long SiCustomerRangeId { get; set; }
        public long? SpecialPriceOverrideItemId { get; set; }
        public long? FromCustomerId { get; set; }
        public long? ToCustomerId { get; set; }
        public long? TraderAnalysisHeaderId { get; set; }
        public string? TraderAnalysisValue { get; set; }
        public string? RangeType { get; set; }
    }
}

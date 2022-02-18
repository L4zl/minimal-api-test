using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconWorkPattern
    {
        public long SiJcWorkPatternId { get; set; }
        public string? Name { get; set; }
        public bool? Deleted { get; set; }
        public short? RateType { get; set; }
        public short? QuantityType { get; set; }
        public decimal MinWorkingHoursBeforeBreak { get; set; }
    }
}

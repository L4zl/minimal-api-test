using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDefaultRate
    {
        public long SiconDefaultRateId { get; set; }
        public int? RateIndex { get; set; }
        public string? RateType { get; set; }
        public string? Description { get; set; }
        public string? PayrollElement { get; set; }
        public int? PayrollRateNo { get; set; }
        public string? DefaultSiJcChd { get; set; }
        public bool? Deleted { get; set; }
    }
}

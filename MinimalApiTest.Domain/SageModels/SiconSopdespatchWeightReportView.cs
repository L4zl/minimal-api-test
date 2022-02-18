using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconSopdespatchWeightReportView
    {
        public string DocumentNo { get; set; } = null!;
        public decimal? DespatchWeight { get; set; }
    }
}

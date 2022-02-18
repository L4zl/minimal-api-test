using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDmsdistReportField
    {
        public long SiconDmsdistReportFieldId { get; set; }
        public long SiconDmsdistributionReportId { get; set; }
        public long SiconDmsdistributionFieldId { get; set; }
        public bool Deleted { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedUser { get; set; } = null!;
    }
}

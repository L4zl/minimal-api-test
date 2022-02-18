using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDmsdistReportCriterion
    {
        public long SiconDmsdistReportCriteriaId { get; set; }
        public long SiconDmsdistributionReportId { get; set; }
        public long SiconDmsdistributionCriteriaId { get; set; }
        public bool Deleted { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedUser { get; set; } = null!;
    }
}

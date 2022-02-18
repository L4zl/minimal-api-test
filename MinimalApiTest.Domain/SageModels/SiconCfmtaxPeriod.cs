using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconCfmtaxPeriod
    {
        public long SiconCfmtaxPeriodId { get; set; }
        public long? SystaxPeriodId { get; set; }
        public bool Paid { get; set; }
        public bool Deleted { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedUser { get; set; } = null!;
    }
}

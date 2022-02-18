using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SystaxPeriodSubmitStatus
    {
        public SystaxPeriodSubmitStatus()
        {
            SystaxPeriods = new HashSet<SystaxPeriod>();
        }

        public long SystaxPeriodSubmitStatusId { get; set; }
        public string Description { get; set; } = null!;

        public virtual ICollection<SystaxPeriod> SystaxPeriods { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SystaxPeriodStatusType
    {
        public SystaxPeriodStatusType()
        {
            SystaxPeriods = new HashSet<SystaxPeriod>();
        }

        public long SystaxPeriodStatusTypeId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<SystaxPeriod> SystaxPeriods { get; set; }
    }
}

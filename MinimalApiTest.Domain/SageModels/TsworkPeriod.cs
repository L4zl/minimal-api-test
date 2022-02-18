using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class TsworkPeriod
    {
        public TsworkPeriod()
        {
            TstimesheetConfigurations = new HashSet<TstimesheetConfiguration>();
        }

        public long TsworkPeriodId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<TstimesheetConfiguration> TstimesheetConfigurations { get; set; }
    }
}

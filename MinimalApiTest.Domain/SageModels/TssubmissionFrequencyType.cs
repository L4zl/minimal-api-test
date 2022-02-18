using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class TssubmissionFrequencyType
    {
        public TssubmissionFrequencyType()
        {
            TstimesheetClientConfigs = new HashSet<TstimesheetClientConfig>();
        }

        public long SubmissionFrequencyTypeId { get; set; }
        public string Description { get; set; } = null!;

        public virtual ICollection<TstimesheetClientConfig> TstimesheetClientConfigs { get; set; }
    }
}

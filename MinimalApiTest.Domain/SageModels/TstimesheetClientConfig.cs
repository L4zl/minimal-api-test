using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class TstimesheetClientConfig
    {
        public TstimesheetClientConfig()
        {
            TstermTimesheetConfigLinks = new HashSet<TstermTimesheetConfigLink>();
        }

        public long TstimesheetClientConfigId { get; set; }
        public bool? SelectCostRates { get; set; }
        public bool DisplayCostValues { get; set; }
        public bool? SelectChargeRates { get; set; }
        public bool DisplayChargeValues { get; set; }
        public bool? SelectPayRates { get; set; }
        public bool DisplayPayValues { get; set; }
        public long TsuserSearchKeyId { get; set; }
        public long TsactivitySearchKeyId { get; set; }
        public long TssubmissionFrequencyTypeId { get; set; }
        public int ZeroSubmissionActivityRetension { get; set; }
        public bool? EnableCostRates { get; set; }
        public bool? EnableChargeRates { get; set; }
        public bool? EnablePayRates { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual TsactivitySearchKey TsactivitySearchKey { get; set; } = null!;
        public virtual TssubmissionFrequencyType TssubmissionFrequencyType { get; set; } = null!;
        public virtual TsuserSearchKey TsuserSearchKey { get; set; } = null!;
        public virtual ICollection<TstermTimesheetConfigLink> TstermTimesheetConfigLinks { get; set; }
    }
}

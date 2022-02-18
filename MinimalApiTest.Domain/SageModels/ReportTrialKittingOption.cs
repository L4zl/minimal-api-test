using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class ReportTrialKittingOption
    {
        public long ReportTrialKittingOptionId { get; set; }
        public long ReportSessionId { get; set; }
        public bool OnOrderAvailable { get; set; }
        public bool OnlyShowShortages { get; set; }
        public bool ReportComponentShortages { get; set; }
        public bool ReportSubAssemblyShortages { get; set; }
        public string SubAssembliesOption { get; set; } = null!;
        public string ShortagesOption { get; set; } = null!;
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual ReportSession ReportSession { get; set; } = null!;
    }
}

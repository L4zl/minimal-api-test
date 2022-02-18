using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class TstermTimesheetConfigLink
    {
        public long TimesheetClientConfigId { get; set; }
        public long TerminologyId { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual Systerminology Terminology { get; set; } = null!;
        public virtual TstimesheetClientConfig TimesheetClientConfig { get; set; } = null!;
    }
}

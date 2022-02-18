using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconTimesheetLineStatus
    {
        public long SiconTimesheetLineStatusId { get; set; }
        public string StatusName { get; set; } = null!;
        public string StatusFriendlyName { get; set; } = null!;
        public bool Deleted { get; set; }
        public string LastUpdatedByUserId { get; set; } = null!;
        public DateTime? LastUpdatedDateTime { get; set; }
    }
}

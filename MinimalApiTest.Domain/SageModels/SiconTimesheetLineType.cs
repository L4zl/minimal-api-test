using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconTimesheetLineType
    {
        public long SiconTimesheetLineTypeId { get; set; }
        public string LineTypeName { get; set; } = null!;
        public string LineTypeFriendlyName { get; set; } = null!;
        public bool Deleted { get; set; }
        public string LastUpdatedByUserId { get; set; } = null!;
        public DateTime? LastUpdatedDateTime { get; set; }
    }
}

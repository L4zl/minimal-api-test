using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconConstructionAccPrdControl
    {
        public long SiconConstAccPrdControlId { get; set; }
        public long? SysaccountingPeriodId { get; set; }
        public long? SysmodulePostingStatusId { get; set; }
        public string? LastUpdatedByUserId { get; set; }
        public DateTime? LastUpdatedByDateTime { get; set; }
    }
}

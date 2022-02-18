using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class TstimesheetConfiguration
    {
        public long TstimesheetConfigurationId { get; set; }
        public bool? AllowWeekendWorking { get; set; }
        public short MaximumHierarchyDepth { get; set; }
        public bool? AllowTimesheetEntry { get; set; }
        public bool RequireTimesheetAuthorisation { get; set; }
        public long TsdayOfWeekId { get; set; }
        public long TstimeUnitTypeId { get; set; }
        public long TsworkPeriodId { get; set; }
        public bool ValidWorkUnitAgainstExpected { get; set; }
        public long NextTimeRecordNumber { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual TsdayOfWeek TsdayOfWeek { get; set; } = null!;
        public virtual TstimeUnitType TstimeUnitType { get; set; } = null!;
        public virtual TsworkPeriod TsworkPeriod { get; set; } = null!;
    }
}

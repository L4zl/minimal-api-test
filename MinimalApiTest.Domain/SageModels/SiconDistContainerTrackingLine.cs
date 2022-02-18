using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDistContainerTrackingLine
    {
        public long SiconDistTrackingLineId { get; set; }
        public long? SiconDistContainerTracking { get; set; }
        public long? SiconDistContainer { get; set; }
        public int LineIndex { get; set; }
        public bool Enabled { get; set; }
        public string Description { get; set; } = null!;
        public int ProfileDays { get; set; }
        public bool WorkingDays { get; set; }
        public DateTime? ProvisionalDate { get; set; }
        public int ProvisionDays { get; set; }
        public DateTime? ActualDate { get; set; }
        public int ActualDays { get; set; }
        public bool Confirmed { get; set; }
        public string Notes { get; set; } = null!;
        public bool Deleted { get; set; }
        public string LastUpdatedBy { get; set; } = null!;
        public DateTime? LastUpdatedDate { get; set; }
        public long? SiconDistPoporderLineProblemId { get; set; }
    }
}

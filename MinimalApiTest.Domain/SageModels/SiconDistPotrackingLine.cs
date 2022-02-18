using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDistPotrackingLine
    {
        public long SiconDistPotrackingLineId { get; set; }
        public long? SiconDistPotracking { get; set; }
        public long? SiconDistPotrackingType { get; set; }
        public long? PoporderReturn { get; set; }
        public long? PoporderReturnLine { get; set; }
        public long? Index { get; set; }
        public bool? Enabled { get; set; }
        public string? Description { get; set; }
        public long? ProfileDays { get; set; }
        public bool? WorkingDays { get; set; }
        public DateTime? ProvisionalDate { get; set; }
        public long? ProvisionalDays { get; set; }
        public DateTime? ActualDate { get; set; }
        public long? ActualDays { get; set; }
        public bool? Confirmed { get; set; }
        public string? Note { get; set; }
        public bool Deleted { get; set; }
        public string? LastUpdatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public long? SiconDistPoporderLineProblemId { get; set; }
    }
}

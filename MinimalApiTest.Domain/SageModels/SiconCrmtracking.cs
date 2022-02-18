using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconCrmtracking
    {
        public long SiconCrmtrackingId { get; set; }
        public string TrackingKey { get; set; } = null!;
        public long ParentId { get; set; }
        public DateTime? TrackingDateTime { get; set; }
        public string TrackingUsername { get; set; } = null!;
        public string TrackingNote { get; set; } = null!;
        public string StageName { get; set; } = null!;
        public short ElapsedDays { get; set; }
        public short ElapsedHours { get; set; }
        public short ElapsedMinutes { get; set; }
        public string CreatedUser { get; set; } = null!;
        public DateTime? CreatedDate { get; set; }
    }
}

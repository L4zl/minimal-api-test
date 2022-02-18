using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDistTrackingProfileLine
    {
        public long SiconDistTrackingProfileLineId { get; set; }
        public long? SiconDistTrackingProfile { get; set; }
        public int Number { get; set; }
        public string Description { get; set; } = null!;
        public int Days { get; set; }
        public bool WorkingDays { get; set; }
        public bool Deleted { get; set; }
        public string LastUpdatedBy { get; set; } = null!;
        public DateTime? LastUpdatedDate { get; set; }
        public long? SiconDistPoporderLineStatusId { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDistTrackingProfile
    {
        public long SiconDistTrackingProfileId { get; set; }
        public string Name { get; set; } = null!;
        public bool Deleted { get; set; }
        public string LastUpdatedBy { get; set; } = null!;
        public DateTime? LastUpdatedDate { get; set; }
    }
}

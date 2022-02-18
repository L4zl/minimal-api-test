using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDistPotrackingProfile
    {
        public long SiconDistPotrackingProfileId { get; set; }
        public string? Name { get; set; }
        public bool Deleted { get; set; }
        public string? LastUpdatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
    }
}

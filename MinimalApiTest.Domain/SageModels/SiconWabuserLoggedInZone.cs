using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconWabuserLoggedInZone
    {
        public long SiconWabuserLoggedInZoneId { get; set; }
        public long SiconWabuserId { get; set; }
        public long SiconWabzoneId { get; set; }
        public DateTime? ZoneLoginDateTime { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconResourceAvailability
    {
        public long SiconResourceAvailabilityId { get; set; }
        public long? SiconResourceId { get; set; }
        public DateTime? Date { get; set; }
        public int? Availability { get; set; }
    }
}

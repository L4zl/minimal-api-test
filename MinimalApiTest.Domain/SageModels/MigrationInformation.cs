using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class MigrationInformation
    {
        public long MigrationInformationId { get; set; }
        public string LastKnownSourceProduct { get; set; } = null!;
        public long? RunCounter { get; set; }
        public long? NextCounterStartId { get; set; }
        public long? NextCounterEndId { get; set; }
        public DateTime? DateTimeUpdated { get; set; }
    }
}

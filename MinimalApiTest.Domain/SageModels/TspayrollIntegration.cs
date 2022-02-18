using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class TspayrollIntegration
    {
        public long TspayrollIntegrationId { get; set; }
        public bool UseRatesAsCosts { get; set; }
        public bool? AutoSynchronise { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime? LastImportDate { get; set; }
        public DateTime? LastSynchroniseEndTime { get; set; }
        public int SynchroniseDelay { get; set; }
        public bool? AccumulatePayments { get; set; }
        public bool UseExtendedPayRateTypes { get; set; }
        public DateTime DateTimeUpdated { get; set; }
    }
}

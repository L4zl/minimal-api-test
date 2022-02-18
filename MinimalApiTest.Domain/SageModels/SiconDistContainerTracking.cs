using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDistContainerTracking
    {
        public long SiconDistContainerTrackingId { get; set; }
        public long? SiconDistTrackingProfile { get; set; }
        public long? SiconDistContainer { get; set; }
        public DateTime? ActualDelDate { get; set; }
        public string VesselName { get; set; } = null!;
        public string BookedInTime { get; set; } = null!;
        public string? Notes { get; set; }
        public decimal Received { get; set; }
        public bool Deleted { get; set; }
        public string Forwarder { get; set; } = null!;
        public bool DocsToForwarder { get; set; }
        public bool Completed { get; set; }
        public string ExpectedTime { get; set; } = null!;
        public string LastUpdatedBy { get; set; } = null!;
        public DateTime? LastUpdatedDate { get; set; }
    }
}

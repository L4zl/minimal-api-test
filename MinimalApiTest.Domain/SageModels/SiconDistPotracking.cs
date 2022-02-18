using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDistPotracking
    {
        public long SiconDistPotrackingId { get; set; }
        public long? SiconDistPotrackingProfile { get; set; }
        public long? PoporderReturn { get; set; }
        public long? PoporderReturnLine { get; set; }
        public DateTime? ActualDelDate { get; set; }
        public string? ContainerNumber { get; set; }
        public string? VesselName { get; set; }
        public string? ContainerSize { get; set; }
        public string? BookedInTime { get; set; }
        public string? Notes { get; set; }
        public bool? Received { get; set; }
        public bool Deleted { get; set; }
        public string? Forwarder { get; set; }
        public bool DocsToForwarder { get; set; }
        public bool Completed { get; set; }
        public string? ExpectedTime { get; set; }
        public string? LastUpdatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
    }
}

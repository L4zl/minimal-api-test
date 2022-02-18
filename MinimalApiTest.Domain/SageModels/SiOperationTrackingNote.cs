using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiOperationTrackingNote
    {
        public long SiOperationTrackingNoteId { get; set; }
        public long? SiOperationHeaderId { get; set; }
        public string? TrackingNote { get; set; }
        public string? TrackingByUser { get; set; }
        public DateTime? TrackingDateTime { get; set; }
    }
}

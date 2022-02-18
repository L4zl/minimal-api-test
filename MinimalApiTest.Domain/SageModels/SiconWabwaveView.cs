using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconWabwaveView
    {
        public long SiconWabwaveId { get; set; }
        public long WaveTypeId { get; set; }
        public string PickNumber { get; set; } = null!;
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; } = null!;
        public int PickStatus { get; set; }
        public DateTime? StatusChangedAt { get; set; }
        public string StatusChangedBy { get; set; } = null!;
        public long? AssignedToSiconWabuserId { get; set; }
    }
}

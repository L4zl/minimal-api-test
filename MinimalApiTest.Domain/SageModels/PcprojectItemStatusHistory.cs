using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PcprojectItemStatusHistory
    {
        public long PcprojectItemStatusHistoryId { get; set; }
        public long PcprojectItemId { get; set; }
        public short? PercentComplete { get; set; }
        public string UserName { get; set; } = null!;
        public DateTime? DateApplied { get; set; }
        public string? Narrative { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public string Description { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }

        public virtual PcprojectItem PcprojectItem { get; set; } = null!;
    }
}

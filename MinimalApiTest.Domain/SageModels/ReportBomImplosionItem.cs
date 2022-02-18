using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class ReportBomImplosionItem
    {
        public long ReportBomImplosionItemId { get; set; }
        public long ReportSessionId { get; set; }
        public string ImplosionType { get; set; } = null!;
        public bool? ImplodeToLevel { get; set; }
        public long? ImplosionLevel { get; set; }
        public string? ImplosionRange { get; set; }
        public string? ParentsSelection { get; set; }
        public string? SelectVersionStatus { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual ReportSession ReportSession { get; set; } = null!;
    }
}

using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class ReportExplosionSetting
    {
        public long ReportExplosionSettingId { get; set; }
        public long ReportSessionId { get; set; }
        public bool? ExplodingToLevel { get; set; }
        public int? ExplodeToLevel { get; set; }
        public bool ExplodingQuantity { get; set; }
        public decimal? ExplodeQuantity { get; set; }
        public string? SelectVersionStatus { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual ReportSession ReportSession { get; set; } = null!;
    }
}

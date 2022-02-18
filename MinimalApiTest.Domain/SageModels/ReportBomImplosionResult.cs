using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class ReportBomImplosionResult
    {
        public long ReportBomImplosionResultId { get; set; }
        public long ReportSessionId { get; set; }
        public long? BomRecordId { get; set; }
        public string? Reference { get; set; }
        public string? DisplayReference { get; set; }
        public string? Description { get; set; }
        public decimal? Quantity { get; set; }
        public string? StockUnitName { get; set; }
        public string LineTypeName { get; set; } = null!;
        public int? HierarchyLevel { get; set; }
        public string? Version { get; set; }
        public string? VersionStatus { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual ReportSession ReportSession { get; set; } = null!;
    }
}

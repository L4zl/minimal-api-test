using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class ReportExplosionResult
    {
        public long ReportExplosionResultId { get; set; }
        public long ReportSessionId { get; set; }
        public int HierarchyLevel { get; set; }
        public long BomComponentLineId { get; set; }
        public string? IndentedReference { get; set; }
        public string? Reference { get; set; }
        public string? Description { get; set; }
        public decimal? Quantity { get; set; }
        public string? UnitOfMeasure { get; set; }
        public long? BomRecordId { get; set; }
        public string LineType { get; set; } = null!;
        public string? BomVersion { get; set; }
        public string? BomVersionStatus { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual ReportSession ReportSession { get; set; } = null!;
    }
}

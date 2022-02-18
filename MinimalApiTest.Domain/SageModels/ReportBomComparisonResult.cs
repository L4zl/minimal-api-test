using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class ReportBomComparisonResult
    {
        public long ReportBomComparisonResultId { get; set; }
        public long ReportBomComparisonItemId { get; set; }
        public long ReportSessionId { get; set; }
        public string Reference1 { get; set; } = null!;
        public string Description1 { get; set; } = null!;
        public string Quantity1 { get; set; } = null!;
        public string UnitOfMeasure1 { get; set; } = null!;
        public long DbKey1 { get; set; }
        public string Reference2 { get; set; } = null!;
        public string Description2 { get; set; } = null!;
        public string Quantity2 { get; set; } = null!;
        public string UnitOfMeasure2 { get; set; } = null!;
        public long DbKey2 { get; set; }
        public string Difference { get; set; } = null!;
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual ReportBomComparisonItem ReportBomComparisonItem { get; set; } = null!;
        public virtual ReportSession ReportSession { get; set; } = null!;
    }
}

using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class ReportBomComparisonItem
    {
        public ReportBomComparisonItem()
        {
            ReportBomComparisonResults = new HashSet<ReportBomComparisonResult>();
        }

        public long ReportBomComparisonItemId { get; set; }
        public long ReportSessionId { get; set; }
        public long Bom1RecordId { get; set; }
        public long Bom2RecordId { get; set; }
        public bool IdentifyDifferencesOnly { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public string Bom1StockCode { get; set; } = null!;
        public string Bom1Description { get; set; } = null!;
        public string Bom1Version { get; set; } = null!;
        public string Bom2StockCode { get; set; } = null!;
        public string Bom2Description { get; set; } = null!;
        public string Bom2Version { get; set; } = null!;
        public string Bom1Status { get; set; } = null!;
        public string Bom2Status { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }

        public virtual ReportSession ReportSession { get; set; } = null!;
        public virtual ICollection<ReportBomComparisonResult> ReportBomComparisonResults { get; set; }
    }
}

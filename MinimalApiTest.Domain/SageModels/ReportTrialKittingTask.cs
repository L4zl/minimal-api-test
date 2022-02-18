using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class ReportTrialKittingTask
    {
        public long ReportTrialKittingTaskId { get; set; }
        public long ReportSessionId { get; set; }
        public long BomRecordId { get; set; }
        public long BuildPackageId { get; set; }
        public string StockCode { get; set; } = null!;
        public string BomVersion { get; set; } = null!;
        public decimal Quantity { get; set; }
        public string UnitOfMeasure { get; set; } = null!;
        public long CumulativeLeadTime { get; set; }
        public string CanBeBuilt { get; set; } = null!;
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual ReportSession ReportSession { get; set; } = null!;
    }
}

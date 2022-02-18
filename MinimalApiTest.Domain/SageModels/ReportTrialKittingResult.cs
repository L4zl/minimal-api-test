using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class ReportTrialKittingResult
    {
        public long ReportTrialKittingResultId { get; set; }
        public long ReportSessionId { get; set; }
        public string ResultType { get; set; } = null!;
        public string StockCode { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Reference { get; set; } = null!;
        public string LineTypeName { get; set; } = null!;
        public decimal QuantityRequired { get; set; }
        public decimal Shortage { get; set; }
        public string StockUnitName { get; set; } = null!;
        public long TimeRequired { get; set; }
        public string Properties { get; set; } = null!;
        public string GroupKey { get; set; } = null!;
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual ReportSession ReportSession { get; set; } = null!;
    }
}

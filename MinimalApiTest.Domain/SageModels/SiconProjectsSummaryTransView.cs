using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconProjectsSummaryTransView
    {
        public long? CurSiJcJobId { get; set; }
        public string? JobNumber { get; set; }
        public long? CurSiJcChdId { get; set; }
        public string? CostCode { get; set; }
        public string? HeaderType { get; set; }
        public string? JobItemTypeCode { get; set; }
        public string ProjectGroup { get; set; } = null!;
        public DateTime? CurPeriodEndDate { get; set; }
        public long? CurSysaccountingPeriodId { get; set; }
        public decimal? CurCommitted { get; set; }
        public decimal? CurActual { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconConstMidetailedTransView
    {
        public long Sijctrnid { get; set; }
        public long? Sijcjobid { get; set; }
        public int? YearRelativeToCurrentYear { get; set; }
        public short? AccountingPeriod { get; set; }
        public long? SysfinancialYearId { get; set; }
        public int? AccountingPeriodYear { get; set; }
        public long? SysaccountingPeriodId { get; set; }
        public string? TransactionDescription { get; set; }
        public string? JobNumber { get; set; }
        public string? Description { get; set; }
        public string? CostCode { get; set; }
        public string? HeaderType { get; set; }
        public string TransType { get; set; } = null!;
        public DateTime? TransDate { get; set; }
        public long? UniqueReferenceNumber { get; set; }
        public decimal? Actual { get; set; }
    }
}

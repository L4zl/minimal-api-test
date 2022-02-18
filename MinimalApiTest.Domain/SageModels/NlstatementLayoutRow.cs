using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class NlstatementLayoutRow
    {
        public long NlstatementLayoutRowId { get; set; }
        public long NlstatementLayoutId { get; set; }
        public long? NlaccountReportCategoryId { get; set; }
        public long Sequence { get; set; }
        public string? Group1 { get; set; }
        public string? Group2 { get; set; }
        public string? Group3 { get; set; }
        public string? Group4 { get; set; }
        public string? Group5 { get; set; }
        public string? Group6 { get; set; }
        public string? Group7 { get; set; }
        public string? Group8 { get; set; }
        public string? Group9 { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public long NllayoutDebitOrCreditTypeId { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual NlaccountReportCategory? NlaccountReportCategory { get; set; }
        public virtual NllayoutDebitOrCreditType NllayoutDebitOrCreditType { get; set; } = null!;
        public virtual NlstatementLayout NlstatementLayout { get; set; } = null!;
    }
}

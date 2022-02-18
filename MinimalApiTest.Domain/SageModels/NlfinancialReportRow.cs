using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class NlfinancialReportRow
    {
        public NlfinancialReportRow()
        {
            NlcashFlowReports = new HashSet<NlcashFlowReport>();
            NlfinancialReportCategories = new HashSet<NlfinancialReportCategory>();
        }

        public long NlfinancialReportRowId { get; set; }
        public long NlfinancialReportLayoutId { get; set; }
        public long NlfinancialReportLineTypeId { get; set; }
        public long NllayoutPositionTypeId { get; set; }
        public long NllayoutDebitOrCreditTypeId { get; set; }
        public short? ReportRow { get; set; }
        public string? Title { get; set; }
        public short? SubtotalGroup { get; set; }
        public bool? PercentageBase { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public int GroupBreak1 { get; set; }
        public int GroupBreak2 { get; set; }
        public int GroupBreak3 { get; set; }
        public int GroupBreak4 { get; set; }
        public int GroupBreak5 { get; set; }
        public int GroupBreak6 { get; set; }
        public int GroupBreak7 { get; set; }
        public int GroupBreak8 { get; set; }
        public int GroupBreak9 { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual NlfinancialReportLayout NlfinancialReportLayout { get; set; } = null!;
        public virtual NlfinancialReportLineType NlfinancialReportLineType { get; set; } = null!;
        public virtual NllayoutDebitOrCreditType NllayoutDebitOrCreditType { get; set; } = null!;
        public virtual NllayoutPositionType NllayoutPositionType { get; set; } = null!;
        public virtual ICollection<NlcashFlowReport> NlcashFlowReports { get; set; }
        public virtual ICollection<NlfinancialReportCategory> NlfinancialReportCategories { get; set; }
    }
}

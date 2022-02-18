using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class NlcashFlowReport
    {
        public long NlcashFlowReportId { get; set; }
        public string Title { get; set; } = null!;
        public long SysfinancialYearId { get; set; }
        public long? NlfinancialReportRowId { get; set; }
        public int? SequenceNumber { get; set; }
        public decimal? Period1Value { get; set; }
        public decimal? Period2Value { get; set; }
        public decimal? Period3Value { get; set; }
        public decimal? Period4Value { get; set; }
        public decimal? Period5Value { get; set; }
        public decimal? Period6Value { get; set; }
        public decimal? Period7Value { get; set; }
        public decimal? Period8Value { get; set; }
        public decimal? Period9Value { get; set; }
        public decimal? Period10Value { get; set; }
        public decimal? Period11Value { get; set; }
        public decimal? Period12Value { get; set; }
        public decimal? Period13Value { get; set; }
        public decimal? Period14Value { get; set; }
        public decimal? Period15Value { get; set; }
        public decimal? Period16Value { get; set; }
        public decimal? Period17Value { get; set; }
        public decimal? Period18Value { get; set; }
        public decimal? Period19Value { get; set; }
        public decimal? Period20Value { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual NlfinancialReportRow? NlfinancialReportRow { get; set; }
        public virtual SysfinancialYear SysfinancialYear { get; set; } = null!;
    }
}

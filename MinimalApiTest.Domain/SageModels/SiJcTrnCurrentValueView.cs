using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiJcTrnCurrentValueView
    {
        public long SiJcTrnCurrentValueId { get; set; }
        public long? SiJcTrnId { get; set; }
        public long? CurSiJcJobId { get; set; }
        public long? CurSiJcchdId { get; set; }
        public long? CurSijobPhaseId { get; set; }
        public long? CurSijobStageId { get; set; }
        public long? CurSijobActivityId { get; set; }
        public long? CurSysaccountingPeriodId { get; set; }
        public decimal? CurCommitted { get; set; }
        public decimal? CurActual { get; set; }
        public string? CurHeaderType { get; set; }
        public DateTime? CurPeriodEndDate { get; set; }
        public decimal? CurCommittedQty { get; set; }
        public decimal? CurActualQty { get; set; }
        public decimal? CurOrderActual { get; set; }
        public decimal? CurSellingPrice { get; set; }
        public decimal? CurExchangeRate { get; set; }
        public decimal? ExchangeRate { get; set; }
        public string NlreportType { get; set; } = null!;
        public string? TransType { get; set; }
        public bool? IsApplications { get; set; }
    }
}

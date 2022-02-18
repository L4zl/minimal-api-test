using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiJcpostedNominalFullView
    {
        public long Id { get; set; }
        public string? Ref { get; set; }
        public string? Cc { get; set; }
        public string? Dept { get; set; }
        public string Name { get; set; } = null!;
        public string NlreportType { get; set; } = null!;
        public string Narrative { get; set; } = null!;
        public decimal GoodsValue { get; set; }
        public DateTime TransactionDate { get; set; }
        public string Reference { get; set; } = null!;
        public long Urn { get; set; }
        public string UserName { get; set; } = null!;
        public DateTime PostedDate { get; set; }
        public long Source { get; set; }
        public short PeriodNumber { get; set; }
        public int YearRelativeToCurrentYear { get; set; }
        public DateTime FinancialYearStartDate { get; set; }
        public decimal GoodsValueInDocumentCurrency { get; set; }
        public decimal ExchangeRate { get; set; }
        public string TransactionAnalysisCode { get; set; } = null!;
        public int Ledger { get; set; }
        public string? TraderAccountNumber { get; set; }
        public string? TraderAccountName { get; set; }
        public long? TraderAccountId { get; set; }
        public long? SiJcTrnId { get; set; }
        public string? OriginalNarrative { get; set; }
        public string? JobNumber { get; set; }
        public string? CostCode { get; set; }
        public string? Phase { get; set; }
        public string? Stage { get; set; }
        public string? Activity { get; set; }
    }
}

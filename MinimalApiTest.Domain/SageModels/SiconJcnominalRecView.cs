using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconJcnominalRecView
    {
        public long Id { get; set; }
        public string Status { get; set; } = null!;
        public string? Ref { get; set; }
        public string? Cc { get; set; }
        public string? Dept { get; set; }
        public string? Name { get; set; }
        public string? NlreportType { get; set; }
        public string Narrative { get; set; } = null!;
        public decimal GoodsValue { get; set; }
        public DateTime TransactionDate { get; set; }
        public string Reference { get; set; } = null!;
        public long? SiconJcnllinkId { get; set; }
        public long? Sijctrnid { get; set; }
        public long? SijctrnnominalRecId { get; set; }
        public string? OriginalNarrative { get; set; }
        public string? Jobnumber { get; set; }
        public string? Costcode { get; set; }
        public long Urn { get; set; }
        public string UserName { get; set; } = null!;
        public DateTime PostedDate { get; set; }
        public long Source { get; set; }
        public string? Excluded { get; set; }
        public long? NlpostedNominalTranId { get; set; }
        public long? NlpendingNominalTranId { get; set; }
        public long? NldeferredNominalTranId { get; set; }
        public long? NlhistoricNominalTranId { get; set; }
        public long? NlaccountReportCategoryId { get; set; }
        public long? SysaccountingPeriodId { get; set; }
        public decimal GoodsValueInDocumentCurrency { get; set; }
        public decimal ExchangeRate { get; set; }
    }
}

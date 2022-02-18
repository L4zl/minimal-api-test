using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconIctranAuditPopline
    {
        public long SiconIctranAuditPoplineId { get; set; }
        public string? TranType { get; set; }
        public long? OriginalCompanyId { get; set; }
        public string? OriginalTranNo { get; set; }
        public string? OriginalTranType { get; set; }
        public long? ChildCompanyId { get; set; }
        public string? ChildCompanyName { get; set; }
        public string? ChildTranNo { get; set; }
        public string? ChildTranType { get; set; }
        public decimal? ChildTranValue { get; set; }
        public string? ChildTranCurrency { get; set; }
        public decimal? ChildTranExchangeRate { get; set; }
        public decimal? ChildTranTaxValue { get; set; }
        public string? ChildTranStatus { get; set; }
        public long? SiconIctranAuditId { get; set; }
        public string? LastUpdatedByUserId { get; set; }
        public DateTime? LastUpdatedDateTime { get; set; }
    }
}

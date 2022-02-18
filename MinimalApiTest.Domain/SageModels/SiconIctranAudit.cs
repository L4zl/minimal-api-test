using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconIctranAudit
    {
        public long SiconIctranAuditId { get; set; }
        public string? TranType { get; set; }
        public long? ParentCompanyId { get; set; }
        public string? ParentCompanyName { get; set; }
        public string? ParentTranNo { get; set; }
        public string? ParentTranType { get; set; }
        public decimal? ParentTranValue { get; set; }
        public string? ParentTranCurrrency { get; set; }
        public decimal? ParentTranExchangeRate { get; set; }
        public decimal? ParentTranTaxValue { get; set; }
        public string? ParentTranStatus { get; set; }
        public long? ChildCompanyId { get; set; }
        public string? ChildCompanyName { get; set; }
        public string? ChildTranNo { get; set; }
        public string? ChildTranType { get; set; }
        public decimal? ChildTranValue { get; set; }
        public string? ChildTranCurrency { get; set; }
        public decimal? ChildTranExchangeRate { get; set; }
        public decimal? ChildTranTaxValue { get; set; }
        public string? ChildTranStatus { get; set; }
        public string? OriginalTranNo { get; set; }
        public string? OriginalTranType { get; set; }
        public decimal? OriginalTranValue { get; set; }
        public string? OriginalTranCurrency { get; set; }
        public decimal? OriginalTranExchangeRate { get; set; }
        public decimal? OriginalTranTaxValue { get; set; }
        public string? OriginalTranStatus { get; set; }
        public DateTime? TranDate { get; set; }
        public string? SourceType { get; set; }
        public string OriginalUrn { get; set; } = null!;
        public string ParentUrn { get; set; } = null!;
        public string ChildUrn { get; set; } = null!;
        public string? LastUpdatedByUserId { get; set; }
        public DateTime? LastUpdatedDateTime { get; set; }
    }
}

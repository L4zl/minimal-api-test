using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconFixedAssetDisposal
    {
        public long DisposalId { get; set; }
        public long FixedAssetId { get; set; }
        public long NominalAccountId1 { get; set; }
        public long NominalAccountId2 { get; set; }
        public long NominalAccountId3 { get; set; }
        public DateTime? DateOfDisposal { get; set; }
        public string? ReasonForDisposal { get; set; }
        public string ReasonForRightOff { get; set; } = null!;
        public decimal? AssetCostValue { get; set; }
        public decimal? DepreciationValue { get; set; }
        public decimal? SaleOfAssetValue { get; set; }
        public string? SalesInvoiceReference { get; set; }
        public DateTime? DateTimeCreated { get; set; }
        public string UserName { get; set; } = null!;
    }
}

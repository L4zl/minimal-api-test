using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconWabkitSoptotePackingView
    {
        public long SoporderReturnId { get; set; }
        public long? WarehouseId { get; set; }
        public int PickStatus { get; set; }
        public DateTime? LinePromisedDate { get; set; }
        public string IdentificationNo { get; set; } = null!;
        public string DocumentNo { get; set; } = null!;
        public long CustomerId { get; set; }
        public string CustomerAccountName { get; set; } = null!;
        public string CustomerAccountNumber { get; set; } = null!;
        public string CustomerDocumentNo { get; set; } = null!;
        public DateTime? HeaderPromisedDate { get; set; }
        public string? CountryCode { get; set; }
        public string Priority { get; set; } = null!;
        public bool? ReadyToPick { get; set; }
        public string AnalysisCode1 { get; set; } = null!;
        public string AnalysisCode2 { get; set; } = null!;
        public string AnalysisCode3 { get; set; } = null!;
        public string AnalysisCode4 { get; set; } = null!;
        public string AnalysisCode5 { get; set; } = null!;
        public string AnalysisCode6 { get; set; } = null!;
        public string AnalysisCode7 { get; set; } = null!;
        public string AnalysisCode8 { get; set; } = null!;
        public string AnalysisCode9 { get; set; } = null!;
        public string AnalysisCode10 { get; set; } = null!;
        public string AnalysisCode11 { get; set; } = null!;
        public string AnalysisCode12 { get; set; } = null!;
        public string AnalysisCode13 { get; set; } = null!;
        public string AnalysisCode14 { get; set; } = null!;
        public string AnalysisCode15 { get; set; } = null!;
        public string AnalysisCode16 { get; set; } = null!;
        public string AnalysisCode17 { get; set; } = null!;
        public string AnalysisCode18 { get; set; } = null!;
        public string AnalysisCode19 { get; set; } = null!;
        public string AnalysisCode20 { get; set; } = null!;
    }
}

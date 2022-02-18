using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconVatanalysis
    {
        public long SiconVatanalysisId { get; set; }
        public int Quarter { get; set; }
        public string Io { get; set; } = null!;
        public string Category { get; set; } = null!;
        public string? ProductType { get; set; }
        public long? NlnominalAccountId { get; set; }
        public string? NominalRef { get; set; }
        public string? NominalCc { get; set; }
        public string? NominalDept { get; set; }
        public string? NominalName { get; set; }
        public string? AccountRef { get; set; }
        public string? AccountName { get; set; }
        public string? Per { get; set; }
        public DateTime? TranDate { get; set; }
        public decimal? GoodsTotal { get; set; }
        public decimal? Vattotal { get; set; }
        public string? NoAcross { get; set; }
        public string? TransRef { get; set; }
        public string? Trans2ndRef { get; set; }
        public long? SystransTypeId { get; set; }
        public string? Vatmth { get; set; }
        public string? UserName { get; set; }
        public int? UserNo { get; set; }
        public string? Src { get; set; }
        public long? Urn { get; set; }
        public string LastUpdatedByUserId { get; set; } = null!;
        public DateTime LastUpdatedDateTime { get; set; }
        public string? Narrative { get; set; }
        public int? TaxCode { get; set; }
        public string? TaxName { get; set; }
        public decimal? TaxRate { get; set; }
    }
}

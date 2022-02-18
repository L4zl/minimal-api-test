using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconConstructionJcsetting
    {
        public long SiconConstructionJcsettingId { get; set; }
        public long? SiJcJobId { get; set; }
        public long? TaxCodeId { get; set; }
        public decimal? SlretentionPc1 { get; set; }
        public decimal? SlretentionPc2 { get; set; }
        public decimal? SlretentionPc3 { get; set; }
        public decimal? SlretentionPc4 { get; set; }
        public DateTime? SlretentionDate1 { get; set; }
        public DateTime? SlretentionDate2 { get; set; }
        public DateTime? SlretentionDate3 { get; set; }
        public DateTime? SlretentionDate4 { get; set; }
        public decimal? PlretentionPc1 { get; set; }
        public decimal? PlretentionPc2 { get; set; }
        public decimal? PlretentionPc3 { get; set; }
        public decimal? PlretentionPc4 { get; set; }
        public DateTime? PlretentionDate1 { get; set; }
        public DateTime? PlretentionDate2 { get; set; }
        public DateTime? PlretentionDate3 { get; set; }
        public DateTime? PlretentionDate4 { get; set; }
        public int NextApplicationNo { get; set; }
        public int NextPlapplicationNo { get; set; }
        public DateTime? LastUpdatedDateTime { get; set; }
        public string LastUpdatedByUserId { get; set; } = null!;
        public decimal MainContractorDiscount { get; set; }
        public long? BillingMethodId { get; set; }
        public string? SiteIdentifyingNumber { get; set; }
        public long? QsemployeeId { get; set; }
    }
}

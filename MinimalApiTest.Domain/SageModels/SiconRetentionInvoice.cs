using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconRetentionInvoice
    {
        public long SiconRetentionInvoiceId { get; set; }
        public long? SiconRetentionId { get; set; }
        public long? PostedTranId { get; set; }
        public string? RetentionInvoiceNo { get; set; }
        public string? TransactionType { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public string? Reference { get; set; }
        public string? SecondReference { get; set; }
        public decimal? ReleasedAmount { get; set; }
        public decimal? OriginalAmount { get; set; }
        public decimal? Cis { get; set; }
        public decimal? Citb { get; set; }
        public decimal? Cisrate { get; set; }
        public decimal? TaxAmount { get; set; }
        public string? JobNumber { get; set; }
        public string? JobHeader { get; set; }
        public string? LastUpdatedByUserId { get; set; }
        public DateTime? LastUpdatedDateTime { get; set; }
    }
}

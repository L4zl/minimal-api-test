using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconRetentionJcjobDisplay
    {
        public long SiconRetentionJcjobDisplayId { get; set; }
        public long? SiconRetentionJcjobListId { get; set; }
        public long? SiconRetentionId { get; set; }
        public long? SiJcJobId { get; set; }
        public string? JobNumber { get; set; }
        public long? SiJcTrnId { get; set; }
        public long? SlcustomerAccountId { get; set; }
        public string? CustomerReference { get; set; }
        public long? PlsupplierAccountId { get; set; }
        public string? SupplierReference { get; set; }
        public string? CreditNoteTransactionReference { get; set; }
        public decimal? RetentionPercentage { get; set; }
        public DateTime? RetentionDueDate { get; set; }
        public decimal? RetentionNetValue { get; set; }
        public decimal? RetentionTaxValue { get; set; }
        public decimal? CreditNoteOutstandingValueNetPos { get; set; }
        public decimal? CreditNoteOutstandingValuePos { get; set; }
        public decimal? ReleasedValueNetPos { get; set; }
        public DateTime? ReleasedDate { get; set; }
        public decimal? ReleasedTaxRate { get; set; }
        public bool? Released { get; set; }
        public bool? WriteOff { get; set; }
    }
}

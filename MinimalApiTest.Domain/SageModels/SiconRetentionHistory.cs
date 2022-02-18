using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconRetentionHistory
    {
        public long SiconRetentionHistoryId { get; set; }
        public string TransactionType { get; set; } = null!;
        public long? SlcustomerAccountId { get; set; }
        public string? CustomerReference { get; set; }
        public long? PlsupplierAccountId { get; set; }
        public string? SupplierReference { get; set; }
        public DateTime? RetentionDueDate { get; set; }
        public string? CreditNoteTransactionReference { get; set; }
        public string? SecondRef { get; set; }
        public string? JcjobNumbers { get; set; }
        public long CreditNoteUrn { get; set; }
        public decimal? RetentionNetValue { get; set; }
        public decimal RetentionPercentage { get; set; }
        public decimal? CreditNoteOutstandingValueNetPos { get; set; }
        public decimal? ReleasedValueNetPos { get; set; }
        public decimal? WriteOffValueNetPos { get; set; }
        public bool? WriteOff { get; set; }
        public long InvoiceUrn { get; set; }
        public int RetentionType { get; set; }
        public string? RetType1 { get; set; }
        public string? RetType2 { get; set; }
    }
}

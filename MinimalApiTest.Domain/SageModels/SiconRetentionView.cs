using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconRetentionView
    {
        public long SiconRetentionId { get; set; }
        public string TransactionType { get; set; } = null!;
        public long? SlcustomerAccountId { get; set; }
        public string? CustomerReference { get; set; }
        public decimal? CustomerTaxRate { get; set; }
        public long? PlsupplierAccountId { get; set; }
        public string? SupplierReference { get; set; }
        public decimal? SupplierTaxRate { get; set; }
        public decimal RetentionPercentage { get; set; }
        public DateTime? RetentionDueDate { get; set; }
        public long InvoiceUrn { get; set; }
        public string? InvoiceReference { get; set; }
        public decimal? InvoiceValue { get; set; }
        public long CreditNoteUrn { get; set; }
        public decimal? CreditNoteValueNet { get; set; }
        public decimal? CreditNoteValueNetPos { get; set; }
        public decimal? CreditNoteValue { get; set; }
        public decimal? CreditNoteValuePos { get; set; }
        public decimal? CreditNoteOutstandingValueNet { get; set; }
        public decimal? CreditNoteOutstandingValueNetPos { get; set; }
        public decimal? CreditNoteOutstandingValue { get; set; }
        public decimal? CreditNoteOutstandingValuePos { get; set; }
        public string? CreditNoteTransactionReference { get; set; }
        public decimal? RetentionNetValue { get; set; }
        public decimal? RetentionTaxValue { get; set; }
        public string? SecondRef { get; set; }
        public short? DiscountDays { get; set; }
        public decimal? DiscountPercent { get; set; }
        public decimal? DiscountValue { get; set; }
        public long NlnominalAccount { get; set; }
        public bool? HasJcjobs { get; set; }
        public string? JcjobNumbers { get; set; }
        public long? SiJctrnId { get; set; }
        public bool? Released { get; set; }
        public DateTime? ReleasedDate { get; set; }
        public decimal? ReleasedValueNet { get; set; }
        public decimal? ReleasedValue { get; set; }
        public decimal? ReleasedValueNetPos { get; set; }
        public decimal? ReleasedValuePos { get; set; }
        public decimal? ReleasedTaxRate { get; set; }
        public bool? WriteOff { get; set; }
        public string? LastUpdatedByUserId { get; set; }
        public DateTime? LastUpdatedDateTime { get; set; }
        public int RetentionType { get; set; }
        public string? RetType1 { get; set; }
        public string? RetType2 { get; set; }
        public decimal? RetentionOriginalNetValue { get; set; }
        public string? ChangedReason { get; set; }
        public string? ChangedByUserId { get; set; }
        public DateTime? ChangedDateTime { get; set; }
        public long? SiconConstructionApplicationId { get; set; }
        public long? SiconConstructionAppLineId { get; set; }
        public DateTime? OriginalTranDate { get; set; }
        public decimal? ExchangeRate { get; set; }
        public decimal? ThisReleased { get; set; }
        public long? SyscurrencyId { get; set; }
        public string? Currency { get; set; }
        public double? JobExchangeRate { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconCitb
    {
        public long SiconCitbid { get; set; }
        public long? PlsupplierAccountId { get; set; }
        public string? SupplierReference { get; set; }
        public decimal? SupplierTaxRate { get; set; }
        public decimal Citbpercentage { get; set; }
        public long InvoiceUrn { get; set; }
        public string? InvoiceReference { get; set; }
        public decimal? InvoiceValue { get; set; }
        public long CreditNoteUrn { get; set; }
        public string? CreditNoteTransactionReference { get; set; }
        public decimal? CreditNoteValue { get; set; }
        public long JournalUrn { get; set; }
        public decimal? JournalValue { get; set; }
        public string? JournalPostingReference { get; set; }
        public decimal? CitbnetValue { get; set; }
        public decimal? CitbtaxValue { get; set; }
        public string? SecondRef { get; set; }
        public short? DiscountDays { get; set; }
        public decimal? DiscountPercent { get; set; }
        public decimal? DiscountValue { get; set; }
        public long NlnominalAccount { get; set; }
        public long NljournalDebitNominalAccount { get; set; }
        public long NljournalCreditNominalAccount { get; set; }
        public string? LastUpdatedByUserId { get; set; }
        public DateTime? LastUpdatedDateTime { get; set; }
    }
}

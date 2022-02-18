using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class NljournalTemplateTran
    {
        public long NljournalTemplateTranId { get; set; }
        public long NljournalTemplateId { get; set; }
        public string? AccountNumber { get; set; }
        public string? CostCentre { get; set; }
        public string? Department { get; set; }
        public string Narrative { get; set; } = null!;
        public decimal TransactionDebitValue { get; set; }
        public decimal TransactionDebitPercentage { get; set; }
        public decimal TransactionCreditValue { get; set; }
        public decimal TransactionCreditPercentage { get; set; }
        public string JournalNumber { get; set; } = null!;
        public string? TransactionAnalysisCode { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public long NljournalTranTaxTypeId { get; set; }
        public long SystaxRateId { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual NljournalTemplate NljournalTemplate { get; set; } = null!;
        public virtual NljournalTranTaxType NljournalTranTaxType { get; set; } = null!;
        public virtual SystaxRate SystaxRate { get; set; } = null!;
    }
}

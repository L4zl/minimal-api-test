using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class NlheldJournalTran
    {
        public long NlheldJournalTranId { get; set; }
        public long NlheldJournalId { get; set; }
        public long NlaccountTypeId { get; set; }
        public long NljournalTranTaxTypeId { get; set; }
        public long? SystaxRateId { get; set; }
        public string AccountNumber { get; set; } = null!;
        public string? CostCentre { get; set; }
        public string? Department { get; set; }
        public string Narrative { get; set; } = null!;
        public decimal DebitValue { get; set; }
        public decimal CreditValue { get; set; }
        public string? TransactionAnalysisCode { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual NlaccountType NlaccountType { get; set; } = null!;
        public virtual NlheldJournal NlheldJournal { get; set; } = null!;
        public virtual NljournalTranTaxType NljournalTranTaxType { get; set; } = null!;
        public virtual SystaxRate? SystaxRate { get; set; }
    }
}

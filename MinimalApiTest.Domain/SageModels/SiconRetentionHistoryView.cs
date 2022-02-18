using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconRetentionHistoryView
    {
        public DateTime? RetentionDueDate { get; set; }
        public string TransactionType { get; set; } = null!;
        public string CustomerReference { get; set; } = null!;
        public string SupplierReference { get; set; } = null!;
        public string? CreditNoteTransactionReference { get; set; }
        public string? SecondRef { get; set; }
        public string? JcjobNumbers { get; set; }
        public long CreditNoteUrn { get; set; }
        public decimal? RetentionNet { get; set; }
        public decimal RetentionPercentage { get; set; }
        public decimal? Outstanding { get; set; }
        public decimal? Released { get; set; }
        public decimal? WriteOff { get; set; }
        public long SiconConstructionApplicationId { get; set; }
    }
}

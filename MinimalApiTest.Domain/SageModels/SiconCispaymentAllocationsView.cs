using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconCispaymentAllocationsView
    {
        public long SiconCispaymentAuditId { get; set; }
        public long? PlsupplierAccountId { get; set; }
        public string? SupplierReference { get; set; }
        public long? PaymentUrn { get; set; }
        public string? PaymentReference { get; set; }
        public DateTime TransactionDate { get; set; }
        public string TransactionType { get; set; } = null!;
        public long? TransactionUrn { get; set; }
        public string? TransactionReference { get; set; }
        public decimal? CisapplicableValue { get; set; }
        public decimal? Cisvalue { get; set; }
        public decimal? Cisrate { get; set; }
        public decimal? TransactionValue { get; set; }
        public decimal? TransactionNet { get; set; }
        public decimal? TransactionTax { get; set; }
        public decimal? LabourValue { get; set; }
        public decimal? MaterialsValue { get; set; }
        public decimal? OtherValue { get; set; }
        public decimal? AmountPayable { get; set; }
        public DateTime? SiconCisreturnPeriodEnd { get; set; }
        public long? DeductionUrn { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class AuditTrailView
    {
        public long UniqueReferenceNumber { get; set; }
        public long Source { get; set; }
        public string AccountNumber { get; set; } = null!;
        public string AccountName { get; set; } = null!;
        public string? NominalAccountNumber { get; set; }
        public string? CostCentre { get; set; }
        public string? Department { get; set; }
        public string? Narrative { get; set; }
        public DateTime? TransactionDate { get; set; }
        public string Reference { get; set; } = null!;
        public string SecondReference { get; set; } = null!;
        public decimal NetValue { get; set; }
        public decimal TaxValue { get; set; }
        public short? Code { get; set; }
        public string Type { get; set; } = null!;
        public long SysauditTrailId { get; set; }
        public string? TradingNominalAnalysisCode { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiJcpendingTsjournalView
    {
        public long SiJcTrnId { get; set; }
        public long? SiJcJobId { get; set; }
        public long? SiJcchdId { get; set; }
        public long? SiJcEmpId { get; set; }
        public long SiconTeamId { get; set; }
        public string? JobNumber { get; set; }
        public string? CostCode { get; set; }
        public string? Employee { get; set; }
        public string Team { get; set; } = null!;
        public string? Rate { get; set; }
        public string? RateType { get; set; }
        public DateTime? TransDate { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? UnitValue { get; set; }
        public decimal? Total { get; set; }
        public long? DeditNominalId { get; set; }
        public string? DeditNominalRef { get; set; }
        public string? DeditNominalCc { get; set; }
        public string? DeditNominalDept { get; set; }
        public string? DebitNominalName { get; set; }
        public long? CreditNominalId { get; set; }
        public string? CreditNominalRef { get; set; }
        public string? CreditNominalCc { get; set; }
        public string? CreditNominalDept { get; set; }
        public string? CreditNominalName { get; set; }
        public string IsValid { get; set; } = null!;
    }
}

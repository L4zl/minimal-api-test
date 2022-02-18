using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconConstructionPrdAccrual
    {
        public long SiconConstructionPrdAccrualId { get; set; }
        public long? SysaccountingPeriodId { get; set; }
        public long? SiJcJobId { get; set; }
        public string? JobNumber { get; set; }
        public long? NlnominalAccountId { get; set; }
        public string? NominalAccountCode { get; set; }
        public string? NominalCostCentre { get; set; }
        public string? NominalDepartment { get; set; }
        public string NominalNarrative { get; set; } = null!;
        public decimal? DebitAmount { get; set; }
        public decimal? CreditAmount { get; set; }
        public string? Reference { get; set; }
        public string? Status { get; set; }
        public string? LastUpdatedByUserId { get; set; }
        public DateTime? LastUpdatedByDateTime { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiNlallocationLine
    {
        public long SiNlallocationLineId { get; set; }
        public long NlallocationId { get; set; }
        public long NlpostedNominalTranId { get; set; }
        public long SysaccountingPeriodId { get; set; }
        public long NlnominalTranTypeId { get; set; }
        public DateTime? TransactionDate { get; set; }
        public decimal? GoodsValueInBaseCurrency { get; set; }
        public int? AllocationLineType { get; set; }
        public string? Reference { get; set; }
        public string? Narrative { get; set; }
        public string? Username { get; set; }
        public string? Source { get; set; }
        public int? UniqueReferenceNumber { get; set; }
        public DateTime? PostedDate { get; set; }
        public string? TransactionAnalysisCode { get; set; }
        public DateTime? TransactionDateTimeCreated { get; set; }
        public int? PeriodNumber { get; set; }
        public decimal? OutstandingAmount { get; set; }
        public long? NlnominalAccountId { get; set; }
    }
}

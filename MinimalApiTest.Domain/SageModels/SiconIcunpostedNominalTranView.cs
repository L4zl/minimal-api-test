using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconIcunpostedNominalTranView
    {
        public long NlnominalAccountId { get; set; }
        public string? AccountNumber { get; set; }
        public string? AccountCostCentre { get; set; }
        public string? AccountDepartment { get; set; }
        public string AccountName { get; set; } = null!;
        public DateTime TransactionDate { get; set; }
        public string Reference { get; set; } = null!;
        public decimal GoodsValueInBaseCurrency { get; set; }
        public long SysaccountingPeriodId { get; set; }
        public long UniqueReferenceNumber { get; set; }
        public long Source { get; set; }
        public long? SiconIcmappedNominalTranId { get; set; }
        public long NlpostedNominalTranId { get; set; }
    }
}

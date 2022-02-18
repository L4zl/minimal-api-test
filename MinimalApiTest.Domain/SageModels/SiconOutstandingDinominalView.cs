using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconOutstandingDinominalView
    {
        public decimal? Amount { get; set; }
        public long NlnominalAccountId { get; set; }
        public string? AccountNumber { get; set; }
        public string? AccountCostCentre { get; set; }
        public string? AccountDepartment { get; set; }
        public string AccountName { get; set; } = null!;
        public decimal? NominalBalance { get; set; }
        public decimal? WaitingPostingsNominalBalance { get; set; }
        public long? TransactionTypeId { get; set; }
    }
}

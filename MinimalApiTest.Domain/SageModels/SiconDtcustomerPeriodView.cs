using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDtcustomerPeriodView
    {
        public string CustomerAccountNumber { get; set; } = null!;
        public string CustomerAccountName { get; set; } = null!;
        public string? Month { get; set; }
        public DateTime TransactionDate { get; set; }
        public decimal? Amount { get; set; }
        public string? PaidStatus { get; set; }
        public string? TransactionStatus { get; set; }
        public string? NewExistingStatus { get; set; }
        public long? TransactionTypeId { get; set; }
    }
}

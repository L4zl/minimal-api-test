using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SlagePeriodBalanceView
    {
        public long MmsslapbCustomerAccountId { get; set; }
        public double? MmsslapbBalance { get; set; }
        public string MmsslapbCustomerAccountNumber { get; set; } = null!;
        public DateTime MmsslapbTransactionDate { get; set; }
    }
}

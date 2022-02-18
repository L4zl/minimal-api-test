using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SltotalOverdueBalancesView
    {
        public string CustomerAccountNumber { get; set; } = null!;
        public string CustomerAccountName { get; set; } = null!;
        public string CustomerAccountShortName { get; set; } = null!;
        public long SlcustomerAccountId { get; set; }
        public decimal? GoodsValueInAccountCurrencyTotal { get; set; }
        public decimal? AllocatedValueTotal { get; set; }
        public decimal? Balance { get; set; }
    }
}

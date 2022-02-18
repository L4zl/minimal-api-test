using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconSlaccountBalanceView
    {
        public long SlcustomerAccountId { get; set; }
        public string CustomerAccountNumber { get; set; } = null!;
        public decimal AccountBalance { get; set; }
        public decimal AccountBalanceNet { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconContractValueCustomerView
    {
        public string CustomerAccountNumber { get; set; } = null!;
        public string CustomerAccountName { get; set; } = null!;
        public long SlcustomerAccountId { get; set; }
        public decimal? Amount { get; set; }
        public decimal? TotalDiscount { get; set; }
        public decimal? TotalNetAfterDiscount { get; set; }
    }
}

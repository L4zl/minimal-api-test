using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconIcslpostedCustomerTranView
    {
        public long SlpostedCustomerTranId { get; set; }
        public string TransactionReference { get; set; } = null!;
        public DateTime TransactionDate { get; set; }
        public long SystraderTranTypeId { get; set; }
        public long? SlcustomerAccountId { get; set; }
        public string? CustomerAccountNumber { get; set; }
        public string? CustomerAccountName { get; set; }
    }
}

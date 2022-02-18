using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconCfmslpostedCustomerTransOutstandingValueView
    {
        public long SlpostedCustomerTranId { get; set; }
        public decimal? Value { get; set; }
        public decimal? ValueAccount { get; set; }
        public long? ControlAccountId { get; set; }
    }
}

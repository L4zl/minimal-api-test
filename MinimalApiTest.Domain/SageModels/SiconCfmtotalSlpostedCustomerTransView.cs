using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconCfmtotalSlpostedCustomerTransView
    {
        public DateTime? DueDate { get; set; }
        public long SyscurrencyId { get; set; }
        public decimal? Value { get; set; }
        public decimal? ValueAccount { get; set; }
        public int BadDebt { get; set; }
    }
}

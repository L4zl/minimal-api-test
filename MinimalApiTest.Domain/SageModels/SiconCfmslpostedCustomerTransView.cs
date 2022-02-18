using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconCfmslpostedCustomerTransView
    {
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public long SlcustomerAccountId { get; set; }
        public DateTime? DueDate { get; set; }
        public decimal? Value { get; set; }
        public decimal? ValueAccount { get; set; }
        public long SyscurrencyId { get; set; }
        public int? Flags { get; set; }
        public int BadDebt { get; set; }
    }
}

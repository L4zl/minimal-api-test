using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconCfmtotalUnallocatedCprview
    {
        public long SlcustomerAccountId { get; set; }
        public string CustomerAccountNumber { get; set; } = null!;
        public string CustomerAccountName { get; set; } = null!;
        public int? Payments { get; set; }
        public int? Receipts { get; set; }
    }
}

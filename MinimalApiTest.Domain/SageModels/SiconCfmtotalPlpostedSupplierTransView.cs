using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconCfmtotalPlpostedSupplierTransView
    {
        public DateTime? DueDate { get; set; }
        public decimal? Value { get; set; }
        public decimal? ValueAccount { get; set; }
        public long SyscurrencyId { get; set; }
        public int BadDebt { get; set; }
    }
}

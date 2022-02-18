using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDistSalesContractView
    {
        public long SiconDistSalesContractId { get; set; }
        public string Name { get; set; } = null!;
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public string CustomerReference { get; set; } = null!;
        public string CustomerAccountName { get; set; } = null!;
    }
}

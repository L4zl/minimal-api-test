using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconContractLineCountView
    {
        public long SiconContractId { get; set; }
        public int? NumberOfLines { get; set; }
        public int? Live { get; set; }
        public int? Expired { get; set; }
        public int? Deleted { get; set; }
        public int? Cancelled { get; set; }
        public int? Pending { get; set; }
        public int? CompletedNonContract { get; set; }
        public int? VariableBilling { get; set; }
    }
}

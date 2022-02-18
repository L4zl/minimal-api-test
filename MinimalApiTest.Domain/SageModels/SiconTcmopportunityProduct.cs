using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconTcmopportunityProduct
    {
        public long SiconTcmopportunityProductId { get; set; }
        public long SiconTcmopportunityId { get; set; }
        public long? ProductId { get; set; }
        public bool? Deleted { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public string UpdatedUser { get; set; } = null!;
    }
}

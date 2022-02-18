using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconWapplpaymentGroup
    {
        public long SiconWapplpaymentGroupId { get; set; }
        public long? PlpaymentGroupId { get; set; }
        public bool RequiresApproval { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedUser { get; set; } = null!;
        public bool Deleted { get; set; }
    }
}

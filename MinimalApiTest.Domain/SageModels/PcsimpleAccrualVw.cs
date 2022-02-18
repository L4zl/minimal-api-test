using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PcsimpleAccrualVw
    {
        public long PcimmediateParentId { get; set; }
        public long BelongsToPcprojectItemId { get; set; }
        public long PcprojectItemId { get; set; }
        public bool IsComplete { get; set; }
    }
}

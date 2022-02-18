using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class TsresourceResourceLink
    {
        public long TsresourceResourceLinkId { get; set; }
        public long OwnerId { get; set; }
        public long ResourceId { get; set; }

        public virtual TshumanResource Owner { get; set; } = null!;
        public virtual TshumanResource Resource { get; set; } = null!;
    }
}

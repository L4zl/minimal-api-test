using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PcprojectResourceLink
    {
        public long PcprojectResourceLinkId { get; set; }
        public long ProjectId { get; set; }
        public long ResourceId { get; set; }

        public virtual PcprojectItem Project { get; set; } = null!;
        public virtual TshumanResource Resource { get; set; } = null!;
    }
}

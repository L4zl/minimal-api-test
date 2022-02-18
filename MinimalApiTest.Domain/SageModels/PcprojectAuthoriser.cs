using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PcprojectAuthoriser
    {
        public long PcprojectAuthoriserId { get; set; }
        public long ProjectId { get; set; }
        public int MmsuserId { get; set; }

        public virtual PcprojectItem Project { get; set; } = null!;
    }
}

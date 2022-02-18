using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class OldMfgBomImage
    {
        public long Id { get; set; }
        public long? HeaderId { get; set; }
        public byte[]? Picture { get; set; }

        public virtual BomHeader? Header { get; set; }
    }
}

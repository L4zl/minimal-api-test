using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class BomImage
    {
        public long BomRecordId { get; set; }
        public byte[] Picture { get; set; } = null!;

        public virtual BomRecord BomRecord { get; set; } = null!;
    }
}

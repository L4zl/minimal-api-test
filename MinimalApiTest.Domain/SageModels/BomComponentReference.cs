using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class BomComponentReference
    {
        public long BomComponentReferenceId { get; set; }
        public long BomComponentLineId { get; set; }
        public string ComponentReference { get; set; } = null!;
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual BomComponentLine BomComponentLine { get; set; } = null!;
    }
}

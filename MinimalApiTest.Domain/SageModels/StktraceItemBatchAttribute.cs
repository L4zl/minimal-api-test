using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class StktraceItemBatchAttribute
    {
        public long StktraceItemBatchAttributeId { get; set; }
        public long TraceableItemId { get; set; }
        public string Title { get; set; } = null!;
        public string Value { get; set; } = null!;
        public bool IsCompulsory { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual TraceableItem TraceableItem { get; set; } = null!;
    }
}

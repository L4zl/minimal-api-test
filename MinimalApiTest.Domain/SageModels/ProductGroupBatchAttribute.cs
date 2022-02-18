using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class ProductGroupBatchAttribute
    {
        public long ProductGroupBatchAttributeId { get; set; }
        public long ProductGroupId { get; set; }
        public string Title { get; set; } = null!;
        public string DefaultValue { get; set; } = null!;
        public bool IsCompulsory { get; set; }
        public bool? IsInUse { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual ProductGroup ProductGroup { get; set; } = null!;
    }
}

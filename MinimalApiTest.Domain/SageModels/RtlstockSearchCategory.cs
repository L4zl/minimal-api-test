using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class RtlstockSearchCategory
    {
        public long SearchId { get; set; }
        public long PrdHierNodeId { get; set; }
        public long SearchCategoryId { get; set; }
        public long SearchValueId { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }
    }
}

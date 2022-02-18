using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SysdocStorageUrl
    {
        public long SysdocStorageUrlid { get; set; }
        public string CloudStorageUrl { get; set; } = null!;
        public long LinkedItemId { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class DeleteLog
    {
        public long DeleteLogId { get; set; }
        public string EntityName { get; set; } = null!;
        public string ForeignId { get; set; } = null!;
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public string? ParentKey { get; set; }
        public string ParentOpLock { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SysunAllocatedUrn
    {
        public long SysunallocatedUrnid { get; set; }
        public int UserId { get; set; }
        public long Source { get; set; }
        public long UniqueReferenceNumber { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }
    }
}

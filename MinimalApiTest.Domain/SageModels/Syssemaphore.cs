using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class Syssemaphore
    {
        public long SyssemaphoreId { get; set; }
        public short? Semaphore { get; set; }
        public string? UserName { get; set; }
        public string? Workstation { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? TimeCreated { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }
    }
}

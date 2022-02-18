using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SysactiveLock
    {
        public long SysactiveLockId { get; set; }
        public long SysuserLoginId { get; set; }
        public string? OptionName { get; set; }
        public string? Data { get; set; }
        public string? UserName { get; set; }
        public string? Workstation { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? TimeCreated { get; set; }
        public long? ProcessId { get; set; }
        public long? DataKey { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }

        public virtual SysuserLogin SysuserLogin { get; set; } = null!;
    }
}

using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SysuserLogin
    {
        public SysuserLogin()
        {
            SysactiveLocks = new HashSet<SysactiveLock>();
            SysfeatureAreaUsages = new HashSet<SysfeatureAreaUsage>();
        }

        public long SysuserLoginId { get; set; }
        public int UserId { get; set; }
        public DateTime LoginTime { get; set; }
        public string? UserName { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public string SessionId { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }

        public virtual ICollection<SysactiveLock> SysactiveLocks { get; set; }
        public virtual ICollection<SysfeatureAreaUsage> SysfeatureAreaUsages { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SysauditSetting
    {
        public long SysauditSettingId { get; set; }
        public DateTime? LastPurgedUpTo { get; set; }
        public DateTime? DatePurgeLastRun { get; set; }
        public int? PurgeUserNumber { get; set; }
        public string? PurgeUserName { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }
    }
}

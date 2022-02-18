using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SyspendingEmail
    {
        public long SyspendingEmailId { get; set; }
        public long SysemailTypeId { get; set; }
        public string? EmailAddress { get; set; }
        public string? EmailSubject { get; set; }
        public string? EmailBody { get; set; }
        public long UserId { get; set; }
        public string UserName { get; set; } = null!;
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual SysemailType SysemailType { get; set; } = null!;
    }
}

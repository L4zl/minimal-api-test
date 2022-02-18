using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SysnotificationUser
    {
        public long SysnotificationUserId { get; set; }
        public long SysnotificationId { get; set; }
        public long UserId { get; set; }
        public string UserName { get; set; } = null!;
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual Sysnotification Sysnotification { get; set; } = null!;
    }
}

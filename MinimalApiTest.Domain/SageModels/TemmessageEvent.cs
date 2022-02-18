using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class TemmessageEvent
    {
        public long TemmessageEventId { get; set; }
        public long TemmessageId { get; set; }
        public DateTime MessageDate { get; set; }
        public DateTime MessageTime { get; set; }
        public long TemeventTypeId { get; set; }
        public string UserName { get; set; } = null!;
        public string ExtraInfo { get; set; } = null!;
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual TemeventType TemeventType { get; set; } = null!;
        public virtual Temmessage Temmessage { get; set; } = null!;
    }
}

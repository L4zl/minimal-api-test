using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDmswebUserSession
    {
        public long SiconDmswebUserSessionId { get; set; }
        public long? SiconDmswebUserId { get; set; }
        public string SessionId { get; set; } = null!;
        public DateTime? SessionStarted { get; set; }
        public DateTime? SessionUpdated { get; set; }
        public DateTime? SessionEnded { get; set; }
        public string Ipaddress { get; set; } = null!;
        public string SessionState { get; set; } = null!;
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedUser { get; set; } = null!;
    }
}

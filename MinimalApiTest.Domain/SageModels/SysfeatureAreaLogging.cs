using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SysfeatureAreaLogging
    {
        public long SysfeatureAreaLoggingId { get; set; }
        public string FormName { get; set; } = null!;
        public string UserName { get; set; } = null!;
        public DateTime DateTimeOfOpen { get; set; }
        public DateTime DateTimeOfClose { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public string Action { get; set; } = null!;
        public bool? Child { get; set; }
        public DateTime DateTimeUpdated { get; set; }
    }
}

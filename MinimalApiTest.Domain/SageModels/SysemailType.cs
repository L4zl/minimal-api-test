using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SysemailType
    {
        public SysemailType()
        {
            SyspendingEmails = new HashSet<SyspendingEmail>();
        }

        public long SysemailTypeId { get; set; }
        public string? Name { get; set; }
        public string? EmailSubject { get; set; }
        public string? EmailBody { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual ICollection<SyspendingEmail> SyspendingEmails { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class CbaccountContact
    {
        public long CbaccountContactId { get; set; }
        public long CbaccountId { get; set; }
        public long SyscontactTypeId { get; set; }
        public string ContactAddress { get; set; } = null!;
        public string ContactName { get; set; } = null!;
        public string Description { get; set; } = null!;
        public bool IsPrimary { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual Cbaccount Cbaccount { get; set; } = null!;
    }
}

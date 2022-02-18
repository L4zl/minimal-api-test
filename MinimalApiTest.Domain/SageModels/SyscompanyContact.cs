using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SyscompanyContact
    {
        public long SyscompanyContactId { get; set; }
        public long SysaddressContactUseId { get; set; }
        public long? SyslocationId { get; set; }
        public long SyscontactTypeId { get; set; }
        public string ContactAddress { get; set; } = null!;
        public string Description { get; set; } = null!;
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual SysaddressContactUse SysaddressContactUse { get; set; } = null!;
        public virtual SyscontactType SyscontactType { get; set; } = null!;
    }
}

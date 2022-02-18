using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SysproviderTypeAttribute
    {
        public SysproviderTypeAttribute()
        {
            SysproviderConfigurationAttributes = new HashSet<SysproviderConfigurationAttribute>();
        }

        public long SysproviderTypeAttributeId { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public long SysproviderTypeId { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public bool IsSensitive { get; set; }
        public long SysproviderTypeAttributeTypeId { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual SysproviderType SysproviderType { get; set; } = null!;
        public virtual SysproviderTypeAttributeType SysproviderTypeAttributeType { get; set; } = null!;
        public virtual ICollection<SysproviderConfigurationAttribute> SysproviderConfigurationAttributes { get; set; }
    }
}

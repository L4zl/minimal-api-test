using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SysproviderConfigurationAttribute
    {
        public long SysproviderConfigurationAttributeId { get; set; }
        public long SysproviderTypeAttributeId { get; set; }
        public long SysproviderConfigurationId { get; set; }
        public string AttributeValue { get; set; } = null!;
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual SysproviderConfiguration SysproviderConfiguration { get; set; } = null!;
        public virtual SysproviderTypeAttribute SysproviderTypeAttribute { get; set; } = null!;
    }
}

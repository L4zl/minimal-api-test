using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SysproviderType
    {
        public SysproviderType()
        {
            SysproviderConfigurations = new HashSet<SysproviderConfiguration>();
            SysproviderTypeAttributes = new HashSet<SysproviderTypeAttribute>();
        }

        public long SysproviderTypeId { get; set; }
        public string Description { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string ProviderType { get; set; } = null!;
        public string ProviderBaseTypeName { get; set; } = null!;
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual ICollection<SysproviderConfiguration> SysproviderConfigurations { get; set; }
        public virtual ICollection<SysproviderTypeAttribute> SysproviderTypeAttributes { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SysproviderConfiguration
    {
        public SysproviderConfiguration()
        {
            SysproviderConfigurationAttributes = new HashSet<SysproviderConfigurationAttribute>();
            TsuserProfiles = new HashSet<TsuserProfile>();
        }

        public long SysproviderConfigurationId { get; set; }
        public string ProviderInstanceName { get; set; } = null!;
        public long SysproviderTypeId { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public string Description { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }

        public virtual SysproviderType SysproviderType { get; set; } = null!;
        public virtual ICollection<SysproviderConfigurationAttribute> SysproviderConfigurationAttributes { get; set; }
        public virtual ICollection<TsuserProfile> TsuserProfiles { get; set; }
    }
}

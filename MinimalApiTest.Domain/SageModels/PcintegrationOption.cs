using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PcintegrationOption
    {
        public PcintegrationOption()
        {
            PccostItemTypeIntegrateSettings = new HashSet<PccostItemTypeIntegrateSetting>();
            PcdefaultIntegrationSettings = new HashSet<PcdefaultIntegrationSetting>();
        }

        public long PcintegrationOptionId { get; set; }
        public long SysmoduleId { get; set; }
        public string Name { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }

        public virtual Sysmodule Sysmodule { get; set; } = null!;
        public virtual ICollection<PccostItemTypeIntegrateSetting> PccostItemTypeIntegrateSettings { get; set; }
        public virtual ICollection<PcdefaultIntegrationSetting> PcdefaultIntegrationSettings { get; set; }
    }
}

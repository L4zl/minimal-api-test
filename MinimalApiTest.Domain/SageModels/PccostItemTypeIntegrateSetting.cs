using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PccostItemTypeIntegrateSetting
    {
        public long PccostItemTypeIntegrateSettingId { get; set; }
        public long PccostItemTypeId { get; set; }
        public long PcintegrationOptionId { get; set; }
        public bool IntegrationEnabled { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }

        public virtual PccostItemType PccostItemType { get; set; } = null!;
        public virtual PcintegrationOption PcintegrationOption { get; set; } = null!;
    }
}

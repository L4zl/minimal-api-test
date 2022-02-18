using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class MseProductGroup
    {
        public long MseProductGroupId { get; set; }
        public long ProductGroupId { get; set; }
        public long? MseContactId { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public bool? UseDemandWarehouse { get; set; }
        public bool? UseWocomponentWarehouse { get; set; }
        public long MsmCostHeadingId { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual MseContact? MseContact { get; set; }
        public virtual MsmCostHeading MsmCostHeading { get; set; } = null!;
    }
}

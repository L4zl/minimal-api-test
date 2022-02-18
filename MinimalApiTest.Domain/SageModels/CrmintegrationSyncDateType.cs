using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class CrmintegrationSyncDateType
    {
        public CrmintegrationSyncDateType()
        {
            CrmintegrationSettings = new HashSet<CrmintegrationSetting>();
        }

        public long CrmintegrationSyncDateTypeId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<CrmintegrationSetting> CrmintegrationSettings { get; set; }
    }
}

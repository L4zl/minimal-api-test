using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class CrmintegrationType
    {
        public CrmintegrationType()
        {
            CrmintegrationSettings = new HashSet<CrmintegrationSetting>();
        }

        public long CrmintegrationTypeId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<CrmintegrationSetting> CrmintegrationSettings { get; set; }
    }
}

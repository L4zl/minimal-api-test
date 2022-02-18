using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class CrmconfigurationType
    {
        public CrmconfigurationType()
        {
            CrmintegrationSettings = new HashSet<CrmintegrationSetting>();
        }

        public long CrmconfigurationTypeId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<CrmintegrationSetting> CrmintegrationSettings { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class CbaccountLocationType
    {
        public CbaccountLocationType()
        {
            CbbankLocations = new HashSet<CbbankLocation>();
        }

        public long CbaccountLocationTypeId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<CbbankLocation> CbbankLocations { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class TsresourceType
    {
        public TsresourceType()
        {
            TsresourceHierarchies = new HashSet<TsresourceHierarchy>();
        }

        public long TsresourceTypeId { get; set; }
        public string Description { get; set; } = null!;

        public virtual ICollection<TsresourceHierarchy> TsresourceHierarchies { get; set; }
    }
}

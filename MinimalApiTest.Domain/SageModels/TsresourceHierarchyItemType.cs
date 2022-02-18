using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class TsresourceHierarchyItemType
    {
        public TsresourceHierarchyItemType()
        {
            TsresourceHierarchies = new HashSet<TsresourceHierarchy>();
        }

        public long TsresourceHierarchyItemTypeId { get; set; }
        public string Description { get; set; } = null!;

        public virtual ICollection<TsresourceHierarchy> TsresourceHierarchies { get; set; }
    }
}

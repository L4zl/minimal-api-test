using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class TsresourceHierarchy
    {
        public TsresourceHierarchy()
        {
            InverseParentHierarchy = new HashSet<TsresourceHierarchy>();
            TsresourceChargeRateLinks = new HashSet<TsresourceChargeRateLink>();
            TsresourceCostRateLinks = new HashSet<TsresourceCostRateLink>();
            TsresourceHierarchyPeople = new HashSet<TsresourceHierarchyPerson>();
        }

        public long TsresourceHierarchyId { get; set; }
        public string Description { get; set; } = null!;
        public long? ParentHierarchyId { get; set; }
        public long TsresourceHierarchyItemTypeId { get; set; }
        public long TsresourceTypeId { get; set; }
        public string Name { get; set; } = null!;
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual TsresourceHierarchy? ParentHierarchy { get; set; }
        public virtual TsresourceHierarchyItemType TsresourceHierarchyItemType { get; set; } = null!;
        public virtual TsresourceType TsresourceType { get; set; } = null!;
        public virtual ICollection<TsresourceHierarchy> InverseParentHierarchy { get; set; }
        public virtual ICollection<TsresourceChargeRateLink> TsresourceChargeRateLinks { get; set; }
        public virtual ICollection<TsresourceCostRateLink> TsresourceCostRateLinks { get; set; }
        public virtual ICollection<TsresourceHierarchyPerson> TsresourceHierarchyPeople { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class TsresourceStatusType
    {
        public TsresourceStatusType()
        {
            TshumanResources = new HashSet<TshumanResource>();
        }

        public long TsresourceStatusTypeId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<TshumanResource> TshumanResources { get; set; }
    }
}

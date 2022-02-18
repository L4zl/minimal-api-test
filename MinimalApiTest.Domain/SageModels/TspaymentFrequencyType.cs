using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class TspaymentFrequencyType
    {
        public TspaymentFrequencyType()
        {
            TshumanResources = new HashSet<TshumanResource>();
        }

        public long TspaymentFrequencyTypeId { get; set; }
        public string Description { get; set; } = null!;

        public virtual ICollection<TshumanResource> TshumanResources { get; set; }
    }
}

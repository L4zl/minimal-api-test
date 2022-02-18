using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDmsdistributionCriterion
    {
        public long SiconDmsdistributionCriteriaId { get; set; }
        public string CriteriaName { get; set; } = null!;
        public string CriteriaFriendlyName { get; set; } = null!;
        public string PersistentObjectAssemblyName { get; set; } = null!;
        public string PersistentObjectName { get; set; } = null!;
        public bool Deleted { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedUser { get; set; } = null!;
    }
}

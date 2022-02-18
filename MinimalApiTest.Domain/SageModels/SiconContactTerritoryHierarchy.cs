using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconContactTerritoryHierarchy
    {
        public long SiconTerritoryHierachyId { get; set; }
        public long? SiconContactTerritoryId { get; set; }
        public long? ImmediateParentTerritoryId { get; set; }
        public long? TopLevelTerritoryId { get; set; }
        public bool Deleted { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public string UpdatedUser { get; set; } = null!;
    }
}

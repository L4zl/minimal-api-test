using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconTerritoryHierachyView
    {
        public long SiconContactTerritoryId { get; set; }
        public string TerritoryName { get; set; } = null!;
        public string TerritoryDescription { get; set; } = null!;
        public long SiconTerritoryHierachyId { get; set; }
        public long? ImmediateParentTerritoryId { get; set; }
        public long? TopLevelTerritoryId { get; set; }
    }
}

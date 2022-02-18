using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconContactTerritory
    {
        public long SiconContactTerritoryId { get; set; }
        public string TerritoryName { get; set; } = null!;
        public string TerritoryDescription { get; set; } = null!;
        public bool Deleted { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public string UpdatedUser { get; set; } = null!;
    }
}

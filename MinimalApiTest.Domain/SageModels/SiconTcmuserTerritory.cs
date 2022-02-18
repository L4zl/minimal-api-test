using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconTcmuserTerritory
    {
        public long SiconTcmuserTerritoryId { get; set; }
        public long? SiconTcmuserId { get; set; }
        public long? SiconContactTerritoryId { get; set; }
        public bool Deleted { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public string UpdatedUser { get; set; } = null!;
    }
}

using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDistStockItemLevel
    {
        public long? SiconDistStockItemLevelId { get; set; }
        public string? Name { get; set; }
        public int? Order { get; set; }
        public bool? CanOrderBy { get; set; }
        public string? LastUpdatedByUserId { get; set; }
        public DateTime? LastUpdatedDateTime { get; set; }
    }
}

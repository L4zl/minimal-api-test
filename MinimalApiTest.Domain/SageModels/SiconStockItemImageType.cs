using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconStockItemImageType
    {
        public long SiconStockItemImageTypeId { get; set; }
        public string ImageTypeName { get; set; } = null!;
        public string ImageTypeFriendlyName { get; set; } = null!;
        public bool IsSystemType { get; set; }
        public bool Deleted { get; set; }
        public string LastUpdatedByUserId { get; set; } = null!;
        public DateTime? LastUpdatedDateTime { get; set; }
    }
}

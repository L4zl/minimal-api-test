using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconWabreplenish
    {
        public long SiconWabreplenishId { get; set; }
        public string ReplenishmentRef { get; set; } = null!;
        public long WarehouseId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Description { get; set; } = null!;
        public bool? IsComplete { get; set; }
        public string DeletedByUserId { get; set; } = null!;
        public DateTime? DeletedDateTime { get; set; }
        public string LastUpdatedByUserId { get; set; } = null!;
        public DateTime? LastUpdatedDateTime { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class Bombuild
    {
        public Bombuild()
        {
            BombuildComponents = new HashSet<BombuildComponent>();
            BombuildFinishedItems = new HashSet<BombuildFinishedItem>();
            BomcostsBookeds = new HashSet<BomcostsBooked>();
        }

        public long BombuildId { get; set; }
        public DateTime BuildDate { get; set; }
        public DateTime BuildTime { get; set; }
        public string BuiltBy { get; set; } = null!;
        public string BomallocationName { get; set; } = null!;
        public string UserAllocationReference { get; set; } = null!;
        public long WarehouseId { get; set; }
        public long BommakeupStockOptionId { get; set; }
        public long BommakeupSubAssOptionId { get; set; }
        public bool IsAllocationWithChanges { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual BommakeupStockOption BommakeupStockOption { get; set; } = null!;
        public virtual BommakeupSubAssOption BommakeupSubAssOption { get; set; } = null!;
        public virtual ICollection<BombuildComponent> BombuildComponents { get; set; }
        public virtual ICollection<BombuildFinishedItem> BombuildFinishedItems { get; set; }
        public virtual ICollection<BomcostsBooked> BomcostsBookeds { get; set; }
    }
}

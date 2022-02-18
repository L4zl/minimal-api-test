using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class BombuildComponent
    {
        public BombuildComponent()
        {
            TraceBombuildComps = new HashSet<TraceBombuildComp>();
        }

        public long BombuildComponentId { get; set; }
        public long BombuildId { get; set; }
        public long BombuildFinishedItemId { get; set; }
        public decimal Quantity { get; set; }
        public long StockItemId { get; set; }
        public long BinItemId { get; set; }
        public decimal CostContribution { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual Bombuild Bombuild { get; set; } = null!;
        public virtual BombuildFinishedItem BombuildFinishedItem { get; set; } = null!;
        public virtual ICollection<TraceBombuildComp> TraceBombuildComps { get; set; }
    }
}

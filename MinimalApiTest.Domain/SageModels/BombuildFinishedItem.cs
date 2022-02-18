using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class BombuildFinishedItem
    {
        public BombuildFinishedItem()
        {
            BombuildComponents = new HashSet<BombuildComponent>();
            InverseIsComponentOf = new HashSet<BombuildFinishedItem>();
            TraceBombuildFinItems = new HashSet<TraceBombuildFinItem>();
        }

        public long BombuildFinishedItemId { get; set; }
        public long BombuildId { get; set; }
        public long? Bomid { get; set; }
        public string Bomversion { get; set; } = null!;
        public string BomshortName { get; set; } = null!;
        public long? IsComponentOfId { get; set; }
        public bool IsIntermediateItem { get; set; }
        public decimal Quantity { get; set; }
        public decimal CostRollUp { get; set; }
        public long StockItemId { get; set; }
        public long BinItemId { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual Bom? Bom { get; set; }
        public virtual Bombuild Bombuild { get; set; } = null!;
        public virtual BombuildFinishedItem? IsComponentOf { get; set; }
        public virtual ICollection<BombuildComponent> BombuildComponents { get; set; }
        public virtual ICollection<BombuildFinishedItem> InverseIsComponentOf { get; set; }
        public virtual ICollection<TraceBombuildFinItem> TraceBombuildFinItems { get; set; }
    }
}

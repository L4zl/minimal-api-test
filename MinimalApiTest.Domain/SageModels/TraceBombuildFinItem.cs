using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class TraceBombuildFinItem
    {
        public TraceBombuildFinItem()
        {
            TraceBombuildComps = new HashSet<TraceBombuildComp>();
        }

        public long TraceBombuildFinItemId { get; set; }
        public long BombuildFinishedItemId { get; set; }
        public long? TraceableBinItemId { get; set; }
        public decimal Quantity { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual BombuildFinishedItem BombuildFinishedItem { get; set; } = null!;
        public virtual ICollection<TraceBombuildComp> TraceBombuildComps { get; set; }
    }
}

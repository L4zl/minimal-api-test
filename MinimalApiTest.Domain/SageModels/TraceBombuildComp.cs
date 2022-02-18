using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class TraceBombuildComp
    {
        public long TraceBombuildCompId { get; set; }
        public long TraceBombuildFinItemId { get; set; }
        public long BombuildComponentId { get; set; }
        public long TraceableBinItemId { get; set; }
        public decimal Quantity { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual BombuildComponent BombuildComponent { get; set; } = null!;
        public virtual TraceBombuildFinItem TraceBombuildFinItem { get; set; } = null!;
    }
}

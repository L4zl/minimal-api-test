using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class TraceableItemStatus
    {
        public TraceableItemStatus()
        {
            TraceableItemArches = new HashSet<TraceableItemArch>();
            TraceableItems = new HashSet<TraceableItem>();
            TraceableTransArchives = new HashSet<TraceableTransArchive>();
            TraceableTransHistories = new HashSet<TraceableTransHistory>();
        }

        public long TraceableItemStatusId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<TraceableItemArch> TraceableItemArches { get; set; }
        public virtual ICollection<TraceableItem> TraceableItems { get; set; }
        public virtual ICollection<TraceableTransArchive> TraceableTransArchives { get; set; }
        public virtual ICollection<TraceableTransHistory> TraceableTransHistories { get; set; }
    }
}

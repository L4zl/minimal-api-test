using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class TraceableTransType
    {
        public TraceableTransType()
        {
            TraceableTransArchives = new HashSet<TraceableTransArchive>();
            TraceableTransHistories = new HashSet<TraceableTransHistory>();
        }

        public long TraceableTransTypeId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<TraceableTransArchive> TraceableTransArchives { get; set; }
        public virtual ICollection<TraceableTransHistory> TraceableTransHistories { get; set; }
    }
}

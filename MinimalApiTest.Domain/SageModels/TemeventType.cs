using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class TemeventType
    {
        public TemeventType()
        {
            TemmessageEvents = new HashSet<TemmessageEvent>();
        }

        public long TemeventTypeId { get; set; }
        public long TemeventSourceId { get; set; }
        public string Name { get; set; } = null!;
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual TemeventSource TemeventSource { get; set; } = null!;
        public virtual ICollection<TemmessageEvent> TemmessageEvents { get; set; }
    }
}

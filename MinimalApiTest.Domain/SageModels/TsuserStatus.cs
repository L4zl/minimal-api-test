using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class TsuserStatus
    {
        public TsuserStatus()
        {
            TsuserProfiles = new HashSet<TsuserProfile>();
        }

        public long TsuserStatusId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<TsuserProfile> TsuserProfiles { get; set; }
    }
}

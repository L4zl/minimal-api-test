using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class TemeventSource
    {
        public TemeventSource()
        {
            TemeventTypes = new HashSet<TemeventType>();
        }

        public long TemeventSourceId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<TemeventType> TemeventTypes { get; set; }
    }
}

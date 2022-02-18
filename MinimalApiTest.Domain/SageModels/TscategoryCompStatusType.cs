using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class TscategoryCompStatusType
    {
        public TscategoryCompStatusType()
        {
            TscategoryComponents = new HashSet<TscategoryComponent>();
        }

        public long TscategoryStatusTypeId { get; set; }
        public string Description { get; set; } = null!;

        public virtual ICollection<TscategoryComponent> TscategoryComponents { get; set; }
    }
}

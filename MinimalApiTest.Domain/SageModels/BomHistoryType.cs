using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class BomHistoryType
    {
        public BomHistoryType()
        {
            BomHistories = new HashSet<BomHistory>();
        }

        public long BomHistoryTypeId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<BomHistory> BomHistories { get; set; }
    }
}

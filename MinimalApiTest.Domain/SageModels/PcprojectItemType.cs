using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PcprojectItemType
    {
        public PcprojectItemType()
        {
            PcprojectItems = new HashSet<PcprojectItem>();
        }

        public long PcprojectItemTypeId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<PcprojectItem> PcprojectItems { get; set; }
    }
}

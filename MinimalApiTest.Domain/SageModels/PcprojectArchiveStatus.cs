using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PcprojectArchiveStatus
    {
        public PcprojectArchiveStatus()
        {
            PcprojectItems = new HashSet<PcprojectItem>();
        }

        public long PcprojectArchiveStatusId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<PcprojectItem> PcprojectItems { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class TsreceiptAttachedType
    {
        public TsreceiptAttachedType()
        {
            TsclaimRecords = new HashSet<TsclaimRecord>();
        }

        public long TsreceiptAttachedTypeId { get; set; }
        public string Description { get; set; } = null!;

        public virtual ICollection<TsclaimRecord> TsclaimRecords { get; set; }
    }
}

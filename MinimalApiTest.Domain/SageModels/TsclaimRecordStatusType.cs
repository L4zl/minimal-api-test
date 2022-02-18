using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class TsclaimRecordStatusType
    {
        public TsclaimRecordStatusType()
        {
            TsclaimRecords = new HashSet<TsclaimRecord>();
        }

        public long TsclaimRecordStatusTypeId { get; set; }
        public string Description { get; set; } = null!;

        public virtual ICollection<TsclaimRecord> TsclaimRecords { get; set; }
    }
}

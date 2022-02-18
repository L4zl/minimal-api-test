using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class TstimesheetPostStatus
    {
        public TstimesheetPostStatus()
        {
            TstimeRecords = new HashSet<TstimeRecord>();
        }

        public long TstimesheetPostingStatusId { get; set; }
        public long TspostedToProjCostStatusId { get; set; }
        public long TspostedToFinancialsStatusId { get; set; }
        public DateTime? PayrollPostingDate { get; set; }
        public DateTime WhenModified { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual TstimesheetPostStatusType TspostedToFinancialsStatus { get; set; } = null!;
        public virtual TstimesheetPostStatusType TspostedToProjCostStatus { get; set; } = null!;
        public virtual ICollection<TstimeRecord> TstimeRecords { get; set; }
    }
}

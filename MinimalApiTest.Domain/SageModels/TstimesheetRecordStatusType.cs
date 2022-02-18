using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class TstimesheetRecordStatusType
    {
        public TstimesheetRecordStatusType()
        {
            TstimeRecords = new HashSet<TstimeRecord>();
            TstimesheetRecordStatuses = new HashSet<TstimesheetRecordStatus>();
        }

        public long TstimesheetRecordStatusTypeId { get; set; }
        public string Description { get; set; } = null!;

        public virtual ICollection<TstimeRecord> TstimeRecords { get; set; }
        public virtual ICollection<TstimesheetRecordStatus> TstimesheetRecordStatuses { get; set; }
    }
}

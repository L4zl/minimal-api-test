using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class TstimesheetRecordStatus
    {
        public long TstimesheetRecordStatusId { get; set; }
        public string? Comments { get; set; }
        public long? TstimesheetRecordStatusTypeId { get; set; }
        public string? Assigner { get; set; }
        public DateTime WhenModified { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual TstimesheetRecordStatusType? TstimesheetRecordStatusType { get; set; }
    }
}

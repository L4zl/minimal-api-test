using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class TsexpensesRecordSheetStatus
    {
        public long TsexpensesRecordSheetStatusId { get; set; }
        public string Comments { get; set; } = null!;
        public long TsexpensesRecordStatusTypeId { get; set; }
        public string Assigner { get; set; } = null!;
        public long TsclaimSheetId { get; set; }
        public DateTime WhenModified { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual TsclaimSheet TsclaimSheet { get; set; } = null!;
        public virtual TsexpensesRecordStatusType TsexpensesRecordStatusType { get; set; } = null!;
    }
}

using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class TsexpensesRecordStatusType
    {
        public TsexpensesRecordStatusType()
        {
            TsexpensesRecordSheetStatuses = new HashSet<TsexpensesRecordSheetStatus>();
        }

        public long TsexpensesRecordStatusTypeId { get; set; }
        public string Description { get; set; } = null!;

        public virtual ICollection<TsexpensesRecordSheetStatus> TsexpensesRecordSheetStatuses { get; set; }
    }
}

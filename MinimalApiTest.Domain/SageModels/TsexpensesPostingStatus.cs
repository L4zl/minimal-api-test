using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class TsexpensesPostingStatus
    {
        public TsexpensesPostingStatus()
        {
            TsclaimSheets = new HashSet<TsclaimSheet>();
        }

        public long TsexpensesPostingStatusId { get; set; }
        public long TspostToProjCostStatusId { get; set; }
        public long TspostToFinancialsStatusId { get; set; }
        public DateTime? PayrollPostingDate { get; set; }
        public DateTime WhenModified { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual TsexpensesPostingStatusType TspostToFinancialsStatus { get; set; } = null!;
        public virtual TsexpensesPostingStatusType TspostToProjCostStatus { get; set; } = null!;
        public virtual ICollection<TsclaimSheet> TsclaimSheets { get; set; }
    }
}

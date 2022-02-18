using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class TsexpensesPostingStatusType
    {
        public TsexpensesPostingStatusType()
        {
            TsexpensesPostingStatusTspostToFinancialsStatuses = new HashSet<TsexpensesPostingStatus>();
            TsexpensesPostingStatusTspostToProjCostStatuses = new HashSet<TsexpensesPostingStatus>();
        }

        public long TsexpensesPostingStatusTypeId { get; set; }
        public string Description { get; set; } = null!;

        public virtual ICollection<TsexpensesPostingStatus> TsexpensesPostingStatusTspostToFinancialsStatuses { get; set; }
        public virtual ICollection<TsexpensesPostingStatus> TsexpensesPostingStatusTspostToProjCostStatuses { get; set; }
    }
}

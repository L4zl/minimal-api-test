using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class TstimesheetPostStatusType
    {
        public TstimesheetPostStatusType()
        {
            TstimesheetPostStatusTspostedToFinancialsStatuses = new HashSet<TstimesheetPostStatus>();
            TstimesheetPostStatusTspostedToProjCostStatuses = new HashSet<TstimesheetPostStatus>();
        }

        public long TspostedStatusTypeId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<TstimesheetPostStatus> TstimesheetPostStatusTspostedToFinancialsStatuses { get; set; }
        public virtual ICollection<TstimesheetPostStatus> TstimesheetPostStatusTspostedToProjCostStatuses { get; set; }
    }
}

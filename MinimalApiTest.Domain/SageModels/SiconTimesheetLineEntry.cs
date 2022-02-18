using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconTimesheetLineEntry
    {
        public long SiconTimesheetLineEntryId { get; set; }
        public long? SiconTimesheetId { get; set; }
        public long? SiconTimesheetLineTypeId { get; set; }
        public long? SiconTimesheetLineStatusId { get; set; }
        public long? SiOperationId { get; set; }
        public long? SiOperationLineId { get; set; }
        public long? SiJcJobId { get; set; }
        public long? SiJcChdId { get; set; }
        public long? SiSmcaseId { get; set; }
        public long? SiWorksOrderId { get; set; }
        public long? SiWorksOrderLineId { get; set; }
        public long? CostRateId { get; set; }
        public long? ChargeRateId { get; set; }
        public long? PayRateId { get; set; }
        public string Narrative { get; set; } = null!;
        public string Notes { get; set; } = null!;
        public bool Deleted { get; set; }
        public string LastUpdatedByUser { get; set; } = null!;
        public DateTime? LastUpdatedDateTime { get; set; }
        public long? SiJobPhaseId { get; set; }
        public long? SiJobStageId { get; set; }
        public long? SiJobActivityId { get; set; }
        public long? SiJobVariationId { get; set; }
        public string Code { get; set; } = null!;
        public string Item { get; set; } = null!;
        public long? LinkedLineId { get; set; }
        public decimal Quantity { get; set; }
    }
}

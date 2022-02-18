using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiOperationActivity
    {
        public long SiOperationActivityId { get; set; }
        public long? SiconEmployeeId { get; set; }
        public string ActvityType { get; set; } = null!;
        public long? SiOperationId { get; set; }
        public long? SiOperationLineId { get; set; }
        public long? SiJcJobId { get; set; }
        public long? SiJcChdId { get; set; }
        public long? SiJobPhaseId { get; set; }
        public long? SiJobStageId { get; set; }
        public long? SiJobActivityId { get; set; }
        public long? SiJcVariationId { get; set; }
        public long? SiWorksOrderId { get; set; }
        public long? SiWorksOrderLineId { get; set; }
        public long TransactionId { get; set; }
        public decimal OperationQuantityComplete { get; set; }
        public decimal OperationPercentageComplete { get; set; }
        public decimal WofinishedItemQuantity { get; set; }
        public bool IsRework { get; set; }
        public string ReworkNotes { get; set; } = null!;
        public DateTime? StartDateTime { get; set; }
        public DateTime? EndDateTime { get; set; }
        public long? TimesheetLineId { get; set; }
        public string LastUpdatedByUserId { get; set; } = null!;
        public DateTime LastUpdatedDateTime { get; set; }
        public long? SiconMachineId { get; set; }
        public string MachineReference { get; set; } = null!;
    }
}

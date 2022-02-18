using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconTcmtask
    {
        public long SiconTcmtaskId { get; set; }
        public string Description { get; set; } = null!;
        public string CompletionDescription { get; set; } = null!;
        public long? SiconTcmmoduleTypeId { get; set; }
        public bool? Deleted { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public string UpdatedUser { get; set; } = null!;
        public long? ModuleTypeForeignId { get; set; }
        public string Summary { get; set; } = null!;
        public DateTime DueDateTime { get; set; }
        public bool? IsComplete { get; set; }
        public DateTime? CompletedDateTime { get; set; }
        public long? SiconContactPersonId { get; set; }
        public long? SiconTcmtaskTypeId { get; set; }
        public long? SiconTcmuserId { get; set; }
        public long? SiJcJobId { get; set; }
        public long? SiJobPhaseId { get; set; }
        public long? SiJobStageId { get; set; }
        public long? SiJobActivityId { get; set; }
        public long? SiJcvariationId { get; set; }
        public DateTime? ReminderDateTime { get; set; }
        public long? SiconTcmreminderTypeId { get; set; }
    }
}

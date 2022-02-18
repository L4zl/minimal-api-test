using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconEquipQuestResponse
    {
        public long SiconEquipQuestResponseId { get; set; }
        public long? SiconAppointmentId { get; set; }
        public long SiconEquipmentCaseId { get; set; }
        public DateTime? DateCompleted { get; set; }
        public long? SiSmcaseTypeId { get; set; }
        public string? CompletedBy { get; set; }
        public long? SiSmquestionWorkflowId { get; set; }
        public bool? PartialCompletion { get; set; }
        public string? Guid { get; set; }
        public long? ReportStatusId { get; set; }
    }
}

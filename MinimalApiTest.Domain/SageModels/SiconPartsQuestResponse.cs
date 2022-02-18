using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconPartsQuestResponse
    {
        public long SiconPartsQuestResponseId { get; set; }
        public long? SiSmstockAvailableForCaseId { get; set; }
        public DateTime? DateCompleted { get; set; }
        public long? SiSmcaseTypeId { get; set; }
        public string? CompletedBy { get; set; }
        public bool? PartialCompletion { get; set; }
        public long? ReportStatusId { get; set; }
        public string? Guid { get; set; }
    }
}

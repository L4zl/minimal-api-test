using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconProjectObjective
    {
        public long SiconProjectObjectiveId { get; set; }
        public long? SiJcJobId { get; set; }
        public int? ObjectiveNumber { get; set; }
        public string? Description { get; set; }
        public DateTime? ExpectedDate { get; set; }
        public bool? Completed { get; set; }
        public DateTime? CompletedDate { get; set; }
        public string? LastUpdatedByUserId { get; set; }
        public DateTime? LastUpdatedDateTime { get; set; }
    }
}

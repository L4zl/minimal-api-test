using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiWorksOrderOpOperation
    {
        public long SiWorksOrderOpOperationId { get; set; }
        public long? OpOperationId { get; set; }
        public long? DayDelay { get; set; }
        public string? LastUpdatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public bool? Inspection { get; set; }
        public long? SiWorksOrderDeptId { get; set; }
    }
}

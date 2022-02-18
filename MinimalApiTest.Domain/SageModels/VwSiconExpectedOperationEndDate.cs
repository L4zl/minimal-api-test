using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class VwSiconExpectedOperationEndDate
    {
        public long? SiWorksOrderId { get; set; }
        public long? SiOperationId { get; set; }
        public int? Sequence { get; set; }
        public DateTime? ExpectedEndDate { get; set; }
        public decimal? ExpectedHours { get; set; }
        public decimal? BookedHours { get; set; }
        public decimal? RemainingHours { get; set; }
        public DateTime? OperationDueDate { get; set; }
        public DateTime? ExpectedStartDate { get; set; }
    }
}

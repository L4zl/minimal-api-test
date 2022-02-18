using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiOperationSubmittedTimeView
    {
        public long? SiOperationId { get; set; }
        public decimal? SubmittedHours { get; set; }
    }
}

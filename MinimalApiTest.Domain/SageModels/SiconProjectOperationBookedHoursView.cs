using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconProjectOperationBookedHoursView
    {
        public long? SiOperationHeaderId { get; set; }
        public decimal? BookedHours { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiSmlabourOnDayView
    {
        public long RecordId { get; set; }
        public long SiconResourceId { get; set; }
        public DateTime? StartTime { get; set; }
        public decimal? Hours { get; set; }
    }
}

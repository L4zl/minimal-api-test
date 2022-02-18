using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiWorksOrderAvailabilityWeek
    {
        public long SiWorksOrderAvailabilityWeekId { get; set; }
        public long? SiWorksOrderAvailabilityId { get; set; }
        public decimal? Week { get; set; }
        public decimal? Year { get; set; }
        public decimal? AvailableHours { get; set; }
        public DateTime? Day { get; set; }
    }
}

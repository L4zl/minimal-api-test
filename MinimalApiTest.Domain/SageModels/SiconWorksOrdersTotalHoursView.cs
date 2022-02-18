using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconWorksOrdersTotalHoursView
    {
        public long SiWorksOrderId { get; set; }
        public int? TotalHours { get; set; }
        public int? TotalMinutes { get; set; }
    }
}

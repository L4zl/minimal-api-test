using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconHmbankHoliday
    {
        public long SiconHmbankHolidayId { get; set; }
        public DateTime? Date { get; set; }
        public string? Description { get; set; }
        public long? SiconHmbankHolidayGroupId { get; set; }
    }
}

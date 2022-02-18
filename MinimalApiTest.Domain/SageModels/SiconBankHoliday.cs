using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconBankHoliday
    {
        public long SiconBankHolidayId { get; set; }
        public DateTime? Date { get; set; }
        public string? Description { get; set; }
        public long SiconBankHolidayGroupId { get; set; }
    }
}

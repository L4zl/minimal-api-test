using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconBankHolidayGroup
    {
        public long SiconBankHolidayGroupId { get; set; }
        public short? UkcountryId { get; set; }
        public string? Name { get; set; }
        public long? SyscountryCodeId { get; set; }
    }
}

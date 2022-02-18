using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconMrpwarehouseSetting
    {
        public long SiconMrpwarehouseSettingId { get; set; }
        public string? Module { get; set; }
        public long? Warehouse { get; set; }
        public bool? IncludeWarehouse { get; set; }
        public long? UserNumber { get; set; }
    }
}

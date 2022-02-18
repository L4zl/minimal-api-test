using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiMrpstockItemSetting
    {
        public long SiMrpstockItemSettingId { get; set; }
        public long? ItemId { get; set; }
        public bool? DoNotIncludeInMrp { get; set; }
        public string? DefaultPurchasingWarehouse { get; set; }
    }
}

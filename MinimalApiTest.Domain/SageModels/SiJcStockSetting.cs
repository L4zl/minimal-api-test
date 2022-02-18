using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiJcStockSetting
    {
        public long SiJcStockSettingId { get; set; }
        public long? ItemId { get; set; }
        public long? DefaultSiJcChdId { get; set; }
        public long? DefaultSiJcChdIssid { get; set; }
        public long? DefaultSiJcChdPopid { get; set; }
        public long? DefaultSiJcChdSopid { get; set; }
        public bool? PostCosasZero { get; set; }
        public long? DefaultSiJcChdWopid { get; set; }
        public long? DefaultSiJcJobId { get; set; }
    }
}

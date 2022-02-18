using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconTcmsetting
    {
        public long SiconTcmsettingId { get; set; }
        public string SettingName { get; set; } = null!;
        public string SettingValue { get; set; } = null!;
        public bool? Deleted { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public string UpdatedUser { get; set; } = null!;
    }
}

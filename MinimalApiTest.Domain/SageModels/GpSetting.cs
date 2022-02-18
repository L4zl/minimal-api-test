using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class GpSetting
    {
        public long GpSettingId { get; set; }
        public bool AllowMultipleConstraints { get; set; }
    }
}

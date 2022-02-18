using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SagePaySetting
    {
        public long SagePaySettingId { get; set; }
        public DateTime? SagePayDownloadDateTime { get; set; }
    }
}

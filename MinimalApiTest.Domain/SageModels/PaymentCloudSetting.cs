using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PaymentCloudSetting
    {
        public long PaymentCloudSettingId { get; set; }
        public DateTime? PaymentCloudDownloadDateTime { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }
    }
}

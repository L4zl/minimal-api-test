using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconMrpcustomerSetting
    {
        public long SiconMrpcustomerSettingId { get; set; }
        public long? CustomerId { get; set; }
        public long? DeliveryBufferDays { get; set; }
        public string? LastUpdatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
    }
}

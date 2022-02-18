using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class RtlsystemSetting
    {
        public long SettingId { get; set; }
        public string VariantSeparatorChar { get; set; } = null!;
        public bool IsUsingBarCode { get; set; }
        public byte BarCodeType { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public string? LastPurgeRunBy { get; set; }
        public DateTime? LastPurgeRunOn { get; set; }
        public DateTime? DateLastPurged { get; set; }
        public DateTime DateTimeUpdated { get; set; }
    }
}

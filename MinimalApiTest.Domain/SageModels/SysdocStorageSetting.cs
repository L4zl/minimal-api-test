using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SysdocStorageSetting
    {
        public long SysdocStorageSettingId { get; set; }
        public string LocalFolderPath { get; set; } = null!;
        public string CloudFolderPath { get; set; } = null!;
        public bool PrintingEnabled { get; set; }
        public bool EmailEnabled { get; set; }
        public bool ConfirmSave { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }
    }
}

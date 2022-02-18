using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SysdocCapture
    {
        public long SysdocCaptureId { get; set; }
        public long SysdocCaptureTypeId { get; set; }
        public long DocPrimaryId { get; set; }
        public string DocUrn { get; set; } = null!;
        public string DocReference { get; set; } = null!;
        public string DocSecondReference { get; set; } = null!;
        public DateTime DocDate { get; set; }
        public long ParentTypeId { get; set; }
        public long ParentPrimaryId { get; set; }
        public string ParentReference { get; set; } = null!;
        public string ParentName { get; set; } = null!;
        public long CaptureUserId { get; set; }
        public string CaptureUserName { get; set; } = null!;
        public string CaptureDescription { get; set; } = null!;
        public string CaptureFileName { get; set; } = null!;
        public long CaptureFileSize { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual SysdocCaptureType SysdocCaptureType { get; set; } = null!;
    }
}

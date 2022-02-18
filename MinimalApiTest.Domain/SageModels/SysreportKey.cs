using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SysreportKey
    {
        public long SysreportKeyId { get; set; }
        public string ReportName { get; set; } = null!;
        public string? ReportFileName { get; set; }
        public bool UploadToDocumentStorage { get; set; }
    }
}

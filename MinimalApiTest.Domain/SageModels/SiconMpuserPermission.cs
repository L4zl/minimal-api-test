using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconMpuserPermission
    {
        public long SiconMpuserPermissionId { get; set; }
        public string? User { get; set; }
        public bool SetPreferredSupplier { get; set; }
        public string? LastUpdatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
    }
}

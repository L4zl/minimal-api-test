using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconKitUserPermission
    {
        public long SiconKitUserPermissionId { get; set; }
        public long? UserNumber { get; set; }
        public string? UserName { get; set; }
        public bool? EditKit { get; set; }
        public string? LastUpdatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
    }
}

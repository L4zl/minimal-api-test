using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDistSopuserPermission
    {
        public long SiconDistSopuserPermissionId { get; set; }
        public string? User { get; set; }
        public bool? CreatePriceBook { get; set; }
        public bool? AmendPriceBook { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public string? LastUpdatedBy { get; set; }
    }
}

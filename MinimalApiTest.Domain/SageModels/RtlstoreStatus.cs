using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class RtlstoreStatus
    {
        public long StoreStatusId { get; set; }
        public string Description { get; set; } = null!;
    }
}

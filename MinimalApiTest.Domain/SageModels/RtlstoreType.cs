using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class RtlstoreType
    {
        public long StoreTypeId { get; set; }
        public string Description { get; set; } = null!;
    }
}

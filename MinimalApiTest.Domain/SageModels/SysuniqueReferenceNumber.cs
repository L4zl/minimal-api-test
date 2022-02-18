using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SysuniqueReferenceNumber
    {
        public long SysuniqueReferenceNumberId { get; set; }
        public long NextUniqueReferenceNumber { get; set; }
    }
}

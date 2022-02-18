using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDistSoporderReturn
    {
        public long? SiconDistSoporderReturnId { get; set; }
        public long? SoporderReturnId { get; set; }
        public string? SoporderStatus { get; set; }
        public long? DefaultFulfilmentMethod { get; set; }
        public string? LastUpdatedByUserId { get; set; }
        public DateTime? LastUpdatedDateTime { get; set; }
    }
}

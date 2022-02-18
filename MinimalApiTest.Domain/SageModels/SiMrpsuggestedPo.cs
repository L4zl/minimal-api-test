using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiMrpsuggestedPo
    {
        public long SiMrpsuggestedPoid { get; set; }
        public string? DocumentNumber { get; set; }
        public long? SupplierId { get; set; }
        public string? User { get; set; }
    }
}

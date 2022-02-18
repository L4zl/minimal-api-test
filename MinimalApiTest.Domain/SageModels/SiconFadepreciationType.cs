using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconFadepreciationType
    {
        public long DepreciationTypeId { get; set; }
        public string DepreciationDescription { get; set; } = null!;
        public bool? Enabled { get; set; }
    }
}

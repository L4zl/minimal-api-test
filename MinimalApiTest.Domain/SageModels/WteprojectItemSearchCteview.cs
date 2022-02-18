using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class WteprojectItemSearchCteview
    {
        public long? PcprojectItemId { get; set; }
        public string? Code { get; set; }
        public string? Title { get; set; }
        public int? AllowCosts { get; set; }
    }
}

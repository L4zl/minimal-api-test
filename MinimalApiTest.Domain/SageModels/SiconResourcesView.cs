using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconResourcesView
    {
        public long Id { get; set; }
        public string Type { get; set; } = null!;
        public string? Name { get; set; }
        public string? Description { get; set; }
        public long? CostWorkPatternId { get; set; }
        public long? GroupId { get; set; }
    }
}

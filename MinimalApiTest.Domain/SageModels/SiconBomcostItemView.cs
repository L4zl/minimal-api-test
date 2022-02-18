using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconBomcostItemView
    {
        public long Id { get; set; }
        public string Reference { get; set; } = null!;
        public string? Description { get; set; }
        public int TypeId { get; set; }
    }
}

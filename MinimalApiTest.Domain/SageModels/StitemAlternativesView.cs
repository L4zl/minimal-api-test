using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class StitemAlternativesView
    {
        public string? MmsstaCode { get; set; }
        public string MmsstaAlternativeItemCode { get; set; } = null!;
        public string MmsstaAlternativeItemName { get; set; } = null!;
        public long MmsstaItemId { get; set; }
        public string? MmsstaPreferred { get; set; }
    }
}

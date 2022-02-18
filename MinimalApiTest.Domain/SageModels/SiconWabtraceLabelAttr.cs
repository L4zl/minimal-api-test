using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconWabtraceLabelAttr
    {
        public long SiconWabtraceLabelAttrId { get; set; }
        public long SiconWabtraceLabelId { get; set; }
        public string Title { get; set; } = null!;
        public string? Value { get; set; }
    }
}

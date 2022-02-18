using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconWabstockHasAttributeView
    {
        public long ItemId { get; set; }
        public string Code { get; set; } = null!;
        public int HasAttributes { get; set; }
    }
}

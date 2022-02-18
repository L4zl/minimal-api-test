using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconFixedAssetType
    {
        public long SiconFixedAssetTypeId { get; set; }
        public string Name { get; set; } = null!;
        public bool Editable { get; set; }
        public bool Removed { get; set; }
    }
}

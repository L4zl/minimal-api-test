using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconFixedAssetFieldListValue
    {
        public long FieldListValueId { get; set; }
        public long SiconFixedAssetFieldId { get; set; }
        public string Value { get; set; } = null!;
    }
}

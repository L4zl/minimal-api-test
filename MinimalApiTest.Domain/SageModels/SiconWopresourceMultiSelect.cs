using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconWopresourceMultiSelect
    {
        public long SiconWopresourceMultiSelectId { get; set; }
        public long? ForeignId { get; set; }
        public string? ForeignType { get; set; }
        public long? ResourceId { get; set; }
        public string? ResourceType { get; set; }
        public int? Priority { get; set; }
    }
}

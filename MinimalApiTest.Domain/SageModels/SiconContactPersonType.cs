using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconContactPersonType
    {
        public long SiconContactPersonTypeId { get; set; }
        public string Description { get; set; } = null!;
        public bool? IsSystem { get; set; }
        public bool? Deleted { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public string UpdatedUser { get; set; } = null!;
        public string ContactPersonTypeName { get; set; } = null!;
    }
}

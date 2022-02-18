using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconProjectItemGroup
    {
        public long SiconProjectItemGroupId { get; set; }
        public long? SiJcJobId { get; set; }
        public int? GroupTitleNumber { get; set; }
        public string? GroupTitleDescription { get; set; }
    }
}

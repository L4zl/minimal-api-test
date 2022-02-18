using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconProjectItemSection
    {
        public long SiconProjectItemSectionId { get; set; }
        public long? SiconProjectItemGroupId { get; set; }
        public int? SectionNumber { get; set; }
        public string? SectionDescription { get; set; }
    }
}

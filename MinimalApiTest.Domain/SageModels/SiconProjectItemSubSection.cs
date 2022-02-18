using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconProjectItemSubSection
    {
        public long SiconProjectItemSubSectionId { get; set; }
        public long? SiconProjectItemSectionId { get; set; }
        public int? SubSectionNumber { get; set; }
        public string? SubSectionDescription { get; set; }
    }
}

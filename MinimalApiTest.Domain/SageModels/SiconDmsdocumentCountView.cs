using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDmsdocumentCountView
    {
        public long? SiconDmsdocumentTypeId { get; set; }
        public string DocumentTypeName { get; set; } = null!;
        public string DocumentTypeFriendlyName { get; set; } = null!;
        public long? SiconDmsattributeId { get; set; }
        public long? ForeignId { get; set; }
        public int? DocumentCount { get; set; }
        public long? SiconDmsentityId { get; set; }
        public string EntityName { get; set; } = null!;
        public string EntityFriendlyName { get; set; } = null!;
    }
}

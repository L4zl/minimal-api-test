using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDmsdocumentsByModuleView
    {
        public long SiconDmsmoduleId { get; set; }
        public string ModuleName { get; set; } = null!;
        public string ModuleFriendlyName { get; set; } = null!;
        public long SiconDmsentityId { get; set; }
        public string EntityName { get; set; } = null!;
        public string EntityFriendlyName { get; set; } = null!;
        public long SiconDmsdocumentTypeId { get; set; }
        public string DocumentTypeName { get; set; } = null!;
        public string DocumentTypeFriendlyName { get; set; } = null!;
        public string ReferenceFolder { get; set; } = null!;
        public int? DocumentCount { get; set; }
    }
}

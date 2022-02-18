using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDmsdocument
    {
        public long SiconDmsdocumentId { get; set; }
        public long? SiconDmsdocumentTypeEntityId { get; set; }
        public bool Deleted { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedUser { get; set; } = null!;
        public long? SiconDmsentityModuleId { get; set; }
    }
}

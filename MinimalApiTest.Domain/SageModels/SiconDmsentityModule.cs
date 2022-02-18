using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDmsentityModule
    {
        public long SiconDmsentityModuleId { get; set; }
        public long? SiconDmsentityId { get; set; }
        public long? SiconDmsmoduleId { get; set; }
        public bool Deleted { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedUser { get; set; } = null!;
    }
}

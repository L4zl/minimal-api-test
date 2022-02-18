using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDmsdocumentRequired
    {
        public long SiconDmsdocumentRequiredId { get; set; }
        public long? SiconDmsentityModuleId { get; set; }
        public long? SiconDmsdocumentTypeEntityId { get; set; }
        public short DocumentRequiredOption { get; set; }
        public bool Deleted { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedUser { get; set; } = null!;
    }
}

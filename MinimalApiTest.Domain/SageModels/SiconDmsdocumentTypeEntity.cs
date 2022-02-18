using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDmsdocumentTypeEntity
    {
        public long SiconDmsdocumentTypeEntityId { get; set; }
        public long? SiconDmsentityId { get; set; }
        public long? SiconDmsdocumentTypeId { get; set; }
        public bool Deleted { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedUser { get; set; } = null!;
    }
}

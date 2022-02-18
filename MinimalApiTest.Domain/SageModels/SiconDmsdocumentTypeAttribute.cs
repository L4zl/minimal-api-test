using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDmsdocumentTypeAttribute
    {
        public long SiconDmsdocumentTypeAttribId { get; set; }
        public long? SiconDmsdocumentTypeId { get; set; }
        public long? SiconDmsattributeId { get; set; }
        public bool Deleted { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedUser { get; set; } = null!;
    }
}

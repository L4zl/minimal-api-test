using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDmstemplateAttribute
    {
        public long SiconDmstemplateAttributeId { get; set; }
        public long? SiconDmstemplateId { get; set; }
        public long? SiconDmsattributeId { get; set; }
        public bool Deleted { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedUser { get; set; } = null!;
    }
}

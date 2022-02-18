using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDmsentityTemplate
    {
        public long SiconDmsentityTemplateId { get; set; }
        public long? SiconDmsentityId { get; set; }
        public long? SiconDmstemplateId { get; set; }
        public bool Deleted { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedUser { get; set; } = null!;
    }
}

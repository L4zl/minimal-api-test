using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDmstemplate
    {
        public long SiconDmstemplateId { get; set; }
        public string TemplateName { get; set; } = null!;
        public string TemplateFriendlyName { get; set; } = null!;
        public bool IsSystem { get; set; }
        public bool Deleted { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedUser { get; set; } = null!;
    }
}

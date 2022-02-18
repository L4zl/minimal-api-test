using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDmsmodule
    {
        public long SiconDmsmoduleId { get; set; }
        public string ModuleName { get; set; } = null!;
        public bool Deleted { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedUser { get; set; } = null!;
        public bool IsSystem { get; set; }
        public string ModuleFriendlyName { get; set; } = null!;
    }
}

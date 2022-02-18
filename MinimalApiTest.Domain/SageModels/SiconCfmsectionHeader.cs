using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconCfmsectionHeader
    {
        public long SiconCfmsectionHeaderId { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public bool Deleted { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedUser { get; set; } = null!;
    }
}

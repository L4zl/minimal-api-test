using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconTcmmemo
    {
        public long SiconTcmmemoId { get; set; }
        public string Description { get; set; } = null!;
        public DateTime? UpdatedDateTime { get; set; }
        public string UpdatedUser { get; set; } = null!;
        public bool? Deleted { get; set; }
        public long SiconTcmtaskId { get; set; }
        public string Summary { get; set; } = null!;
    }
}

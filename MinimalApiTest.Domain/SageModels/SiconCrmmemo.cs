using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconCrmmemo
    {
        public long SiconCrmmemoId { get; set; }
        public string MemoKey { get; set; } = null!;
        public long ParentId { get; set; }
        public string Memo { get; set; } = null!;
        public DateTime? MemoDateTime { get; set; }
        public string MemoUser { get; set; } = null!;
        public bool? Deleted { get; set; }
        public string CreatedUser { get; set; } = null!;
        public DateTime? CreatedDate { get; set; }
        public string UpdatedUser { get; set; } = null!;
        public DateTime? UpdatedDate { get; set; }
    }
}

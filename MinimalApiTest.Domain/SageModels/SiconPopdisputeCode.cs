using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconPopdisputeCode
    {
        public long SiconPopdisputeCodeId { get; set; }
        public long PopdisputeCodeId { get; set; }
        public bool CommentMandatory { get; set; }
        public string LastUpdatedByUserId { get; set; } = null!;
        public DateTime LastUpdatedDateTime { get; set; }
    }
}

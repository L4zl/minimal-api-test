using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconCfmmemo
    {
        public long SiconCfmmemoId { get; set; }
        public string MemoSource { get; set; } = null!;
        public long? MemoForeignId { get; set; }
        public string Note { get; set; } = null!;
        public string CreatedBy { get; set; } = null!;
        public DateTime? DateStamp { get; set; }
        public bool IsActive { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedUser { get; set; } = null!;
        public bool Deleted { get; set; }
    }
}

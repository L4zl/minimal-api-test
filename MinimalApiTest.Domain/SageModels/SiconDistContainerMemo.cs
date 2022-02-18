using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDistContainerMemo
    {
        public long SiconDistContainerMemoId { get; set; }
        public long? SiconDistContainer { get; set; }
        public string MemoText { get; set; } = null!;
        public string CreatedBy { get; set; } = null!;
        public DateTime? CreatedDate { get; set; }
        public bool Deleted { get; set; }
        public string UpdatedBy { get; set; } = null!;
        public DateTime? UpdatedDate { get; set; }
    }
}

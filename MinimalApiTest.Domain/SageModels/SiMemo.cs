using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiMemo
    {
        public long SiMemoId { get; set; }
        public long SageDbkey { get; set; }
        public int MemoType { get; set; }
        public string MemoText { get; set; } = null!;
        public string MemoCreatedBy { get; set; } = null!;
        public DateTime MemoCreatedDate { get; set; }
        public string? MemoStatus { get; set; }
        public DateTime? FollowUpDate { get; set; }
        public string? FollowUpUser { get; set; }
    }
}

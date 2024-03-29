﻿using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiJcMemo
    {
        public long MemoId { get; set; }
        public long? SiJcJobId { get; set; }
        public int? MemoType { get; set; }
        public string? MemoText { get; set; }
        public string? MemoCreatedBy { get; set; }
        public DateTime? MemoCreatedDate { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SlaccountMemo
    {
        public long SlaccountMemoId { get; set; }
        public long SlcustomerAccountId { get; set; }
        public string MemoText { get; set; } = null!;
        public string MemoCreatedBy { get; set; } = null!;
        public DateTime TimeAndDateMemoCreated { get; set; }
        public bool Active { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public long SysaccountMemoTypeId { get; set; }
        public DateTime TimeAndDateMemoLastUpdated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual SlcustomerAccount SlcustomerAccount { get; set; } = null!;
        public virtual SysaccountMemoType SysaccountMemoType { get; set; } = null!;
    }
}
﻿using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SysdisplayField
    {
        public long SysdisplayFieldId { get; set; }
        public long SysfieldDescriptorId { get; set; }
        public long SyssearchId { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }

        public virtual SysfieldDescriptor SysfieldDescriptor { get; set; } = null!;
        public virtual Syssearch Syssearch { get; set; } = null!;
    }
}

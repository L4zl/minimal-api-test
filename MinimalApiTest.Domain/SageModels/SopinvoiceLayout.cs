using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SopinvoiceLayout
    {
        public long SopinvoiceLayoutId { get; set; }
        public string Description { get; set; } = null!;
        public string FileName { get; set; } = null!;
        public bool IsDefaultLayout { get; set; }
        public short? LayoutType { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }
    }
}

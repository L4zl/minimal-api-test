using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SysfieldDescriptor
    {
        public SysfieldDescriptor()
        {
            SysdisplayFields = new HashSet<SysdisplayField>();
            SysexpressionLines = new HashSet<SysexpressionLine>();
            SyssearchFields = new HashSet<SyssearchField>();
        }

        public long SysfieldDescriptorId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<SysdisplayField> SysdisplayFields { get; set; }
        public virtual ICollection<SysexpressionLine> SysexpressionLines { get; set; }
        public virtual ICollection<SyssearchField> SyssearchFields { get; set; }
    }
}

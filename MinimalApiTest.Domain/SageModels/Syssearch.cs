using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class Syssearch
    {
        public Syssearch()
        {
            SysdisplayFields = new HashSet<SysdisplayField>();
            SysexpressionLines = new HashSet<SysexpressionLine>();
            SyssearchFields = new HashSet<SyssearchField>();
        }

        public long SyssearchId { get; set; }
        public string Name { get; set; } = null!;
        public bool IsDefault { get; set; }
        public bool ShowExpressionWithResults { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }

        public virtual ICollection<SysdisplayField> SysdisplayFields { get; set; }
        public virtual ICollection<SysexpressionLine> SysexpressionLines { get; set; }
        public virtual ICollection<SyssearchField> SyssearchFields { get; set; }
    }
}

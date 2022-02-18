using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class Pssearch
    {
        public Pssearch()
        {
            PsdisplayFields = new HashSet<PsdisplayField>();
            PsexpressionLines = new HashSet<PsexpressionLine>();
            PssearchFields = new HashSet<PssearchField>();
        }

        public long PssearchId { get; set; }
        public string Name { get; set; } = null!;
        public bool IsDefault { get; set; }
        public bool ShowExpressionWithResults { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }

        public virtual ICollection<PsdisplayField> PsdisplayFields { get; set; }
        public virtual ICollection<PsexpressionLine> PsexpressionLines { get; set; }
        public virtual ICollection<PssearchField> PssearchFields { get; set; }
    }
}

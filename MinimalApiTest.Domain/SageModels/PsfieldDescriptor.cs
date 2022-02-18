using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PsfieldDescriptor
    {
        public PsfieldDescriptor()
        {
            PsdisplayFields = new HashSet<PsdisplayField>();
            PsexpressionLines = new HashSet<PsexpressionLine>();
            PssearchFields = new HashSet<PssearchField>();
        }

        public long PsfieldDescriptorId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<PsdisplayField> PsdisplayFields { get; set; }
        public virtual ICollection<PsexpressionLine> PsexpressionLines { get; set; }
        public virtual ICollection<PssearchField> PssearchFields { get; set; }
    }
}

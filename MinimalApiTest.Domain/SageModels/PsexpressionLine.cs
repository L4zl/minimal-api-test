using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PsexpressionLine
    {
        public long PsexpressionLineId { get; set; }
        public long PssearchId { get; set; }
        public long PslogicalOperatorDescriptorId { get; set; }
        public long PscondOperatorDescriptorId { get; set; }
        public long PsfieldDescriptorId { get; set; }
        public string Value { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }

        public virtual PscondOperatorDescriptor PscondOperatorDescriptor { get; set; } = null!;
        public virtual PsfieldDescriptor PsfieldDescriptor { get; set; } = null!;
        public virtual PslogicalOperatorDescriptor PslogicalOperatorDescriptor { get; set; } = null!;
        public virtual Pssearch Pssearch { get; set; } = null!;
    }
}

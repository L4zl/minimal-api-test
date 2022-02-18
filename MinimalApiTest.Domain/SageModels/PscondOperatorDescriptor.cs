using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PscondOperatorDescriptor
    {
        public PscondOperatorDescriptor()
        {
            PsexpressionLines = new HashSet<PsexpressionLine>();
        }

        public long PscondOperatorDescriptorId { get; set; }
        public long PscondOperatorTypeId { get; set; }

        public virtual PscondOperatorType PscondOperatorType { get; set; } = null!;
        public virtual ICollection<PsexpressionLine> PsexpressionLines { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PslogicalOperatorDescriptor
    {
        public PslogicalOperatorDescriptor()
        {
            PsexpressionLines = new HashSet<PsexpressionLine>();
        }

        public long PslogicalOperatorDescriptorId { get; set; }
        public long PslogicalOperatorTypeId { get; set; }

        public virtual PslogicalOperatorType PslogicalOperatorType { get; set; } = null!;
        public virtual ICollection<PsexpressionLine> PsexpressionLines { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SyscondOperatorDescriptor
    {
        public SyscondOperatorDescriptor()
        {
            SysexpressionLines = new HashSet<SysexpressionLine>();
        }

        public long SyscondOperatorDescriptorId { get; set; }
        public long SyscondOperatorTypeId { get; set; }

        public virtual SyscondOperatorType SyscondOperatorType { get; set; } = null!;
        public virtual ICollection<SysexpressionLine> SysexpressionLines { get; set; }
    }
}

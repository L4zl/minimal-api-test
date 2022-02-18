using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SyslogicalOperatorDescriptor
    {
        public SyslogicalOperatorDescriptor()
        {
            SysexpressionLines = new HashSet<SysexpressionLine>();
        }

        public long SyslogicalOperatorDescriptorId { get; set; }
        public long SyslogicalOperatorTypeId { get; set; }

        public virtual SyslogicalOperatorType SyslogicalOperatorType { get; set; } = null!;
        public virtual ICollection<SysexpressionLine> SysexpressionLines { get; set; }
    }
}

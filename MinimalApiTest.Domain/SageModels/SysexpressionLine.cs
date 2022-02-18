using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SysexpressionLine
    {
        public long SysexpressionLineId { get; set; }
        public long SyssearchId { get; set; }
        public long SyslogicalOperatorDescriptorId { get; set; }
        public long SyscondOperatorDescriptorId { get; set; }
        public long SysfieldDescriptorId { get; set; }
        public string Value { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }

        public virtual SyscondOperatorDescriptor SyscondOperatorDescriptor { get; set; } = null!;
        public virtual SysfieldDescriptor SysfieldDescriptor { get; set; } = null!;
        public virtual SyslogicalOperatorDescriptor SyslogicalOperatorDescriptor { get; set; } = null!;
        public virtual Syssearch Syssearch { get; set; } = null!;
    }
}

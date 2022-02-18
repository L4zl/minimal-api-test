using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SyslogicalOperatorType
    {
        public SyslogicalOperatorType()
        {
            SyslogicalOperatorDescriptors = new HashSet<SyslogicalOperatorDescriptor>();
        }

        public long SyslogicalOperatorTypeId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<SyslogicalOperatorDescriptor> SyslogicalOperatorDescriptors { get; set; }
    }
}

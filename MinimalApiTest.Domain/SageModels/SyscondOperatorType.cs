using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SyscondOperatorType
    {
        public SyscondOperatorType()
        {
            SyscondOperatorDescriptors = new HashSet<SyscondOperatorDescriptor>();
        }

        public long SyscondOperatorTypeId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<SyscondOperatorDescriptor> SyscondOperatorDescriptors { get; set; }
    }
}

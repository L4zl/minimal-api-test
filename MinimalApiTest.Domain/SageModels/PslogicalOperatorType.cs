using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PslogicalOperatorType
    {
        public PslogicalOperatorType()
        {
            PslogicalOperatorDescriptors = new HashSet<PslogicalOperatorDescriptor>();
        }

        public long PslogicalOperatorTypeId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<PslogicalOperatorDescriptor> PslogicalOperatorDescriptors { get; set; }
    }
}

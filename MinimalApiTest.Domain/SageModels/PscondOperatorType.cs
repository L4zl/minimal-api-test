using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PscondOperatorType
    {
        public PscondOperatorType()
        {
            PscondOperatorDescriptors = new HashSet<PscondOperatorDescriptor>();
        }

        public long PscondOperatorTypeId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<PscondOperatorDescriptor> PscondOperatorDescriptors { get; set; }
    }
}

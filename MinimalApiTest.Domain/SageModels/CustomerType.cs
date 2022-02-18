using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class CustomerType
    {
        public CustomerType()
        {
            SoporderReturnArches = new HashSet<SoporderReturnArch>();
            SoporderReturns = new HashSet<SoporderReturn>();
        }

        public long CustomerTypeId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<SoporderReturnArch> SoporderReturnArches { get; set; }
        public virtual ICollection<SoporderReturn> SoporderReturns { get; set; }
    }
}

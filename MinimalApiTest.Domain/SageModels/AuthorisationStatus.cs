using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class AuthorisationStatus
    {
        public AuthorisationStatus()
        {
            PoporderReturnArches = new HashSet<PoporderReturnArch>();
            PoporderReturns = new HashSet<PoporderReturn>();
        }

        public long AuthorisationStatusId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<PoporderReturnArch> PoporderReturnArches { get; set; }
        public virtual ICollection<PoporderReturn> PoporderReturns { get; set; }
    }
}

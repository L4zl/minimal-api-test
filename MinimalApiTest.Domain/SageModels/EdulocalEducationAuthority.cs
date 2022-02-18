using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class EdulocalEducationAuthority
    {
        public EdulocalEducationAuthority()
        {
            Syscompanies = new HashSet<Syscompany>();
        }

        public long EdulocalEducationAuthorityId { get; set; }
        public string Name { get; set; } = null!;
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }
        public bool EnforcesMandatoryNominalCodes { get; set; }

        public virtual ICollection<Syscompany> Syscompanies { get; set; }
    }
}

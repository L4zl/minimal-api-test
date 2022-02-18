using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class AuthoriserType
    {
        public AuthoriserType()
        {
            Authorisers = new HashSet<Authoriser>();
        }

        public long AuthoriserTypeId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Authoriser> Authorisers { get; set; }
    }
}

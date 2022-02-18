using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class Authoriser
    {
        public Authoriser()
        {
            InverseAuthoriserParent = new HashSet<Authoriser>();
        }

        public long AuthoriserId { get; set; }
        public long AuthoriserTypeId { get; set; }
        public long ItemId { get; set; }
        public long UserId { get; set; }
        public string AuthoriserName { get; set; } = null!;
        public long? AlternativeAuthoriserId { get; set; }
        public long? AuthoriserParentId { get; set; }
        public long AuthorisationGroup { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual Authoriser? AuthoriserParent { get; set; }
        public virtual AuthoriserType AuthoriserType { get; set; } = null!;
        public virtual ICollection<Authoriser> InverseAuthoriserParent { get; set; }
    }
}

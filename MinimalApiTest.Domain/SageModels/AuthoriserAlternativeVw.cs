using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class AuthoriserAlternativeVw
    {
        public long AuthoriserId { get; set; }
        public long UserId { get; set; }
        public long ItemId { get; set; }
        public long? AlternativeUserItemId { get; set; }
        public long AuthorisationGroup { get; set; }
    }
}

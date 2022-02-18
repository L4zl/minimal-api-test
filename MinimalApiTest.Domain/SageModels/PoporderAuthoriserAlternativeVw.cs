using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PoporderAuthoriserAlternativeVw
    {
        public long PoporderAuthoriserId { get; set; }
        public long UserId { get; set; }
        public long PoporderReturnId { get; set; }
        public long? AlternativeUserPoporderReturnId { get; set; }
        public long AuthorisationGroup { get; set; }
    }
}

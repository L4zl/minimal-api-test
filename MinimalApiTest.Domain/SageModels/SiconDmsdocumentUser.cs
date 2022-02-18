using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDmsdocumentUser
    {
        public long SiconDmsdocumentUserId { get; set; }
        public long? SiconDmsdocumentId { get; set; }
        public long? SageUserId { get; set; }
        public bool Deleted { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedUser { get; set; } = null!;
    }
}

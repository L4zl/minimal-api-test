using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDmsdocumentRole
    {
        public long SiconDmsdocumentRoleId { get; set; }
        public long? SageRoleId { get; set; }
        public long? SiconDmsdocumentId { get; set; }
        public bool Deleted { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedUser { get; set; } = null!;
    }
}

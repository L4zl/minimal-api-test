using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDmsentity
    {
        public long SiconDmsentityId { get; set; }
        public string EntityName { get; set; } = null!;
        public string EntityFriendlyName { get; set; } = null!;
        public bool IsSystem { get; set; }
        public bool Deleted { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedUser { get; set; } = null!;
    }
}

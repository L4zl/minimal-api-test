using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDdsDatabaseVersion
    {
        public long SiconDdsDatabaseVersionId { get; set; }
        public int VersionNumber { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedUser { get; set; } = null!;
    }
}

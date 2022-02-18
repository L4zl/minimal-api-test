using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class WorkspacesContentPartFilter
    {
        public long ContentPartFilterId { get; set; }
        public string ContentPartId { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Filters { get; set; } = null!;
        public string Version { get; set; } = null!;
        public long UserId { get; set; }
    }
}

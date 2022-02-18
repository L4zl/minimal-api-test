using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PcprojectRootStatusVw
    {
        public long PcprojectItemId { get; set; }
        public string Code { get; set; } = null!;
        public string Title { get; set; } = null!;
        public long ProjectStatusId { get; set; }
        public string Description { get; set; } = null!;
    }
}

using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PcprojectArchiveVw
    {
        public long PcprojectItemId { get; set; }
        public long ProjectStatusId { get; set; }
        public string Code { get; set; } = null!;
        public string Title { get; set; } = null!;
    }
}

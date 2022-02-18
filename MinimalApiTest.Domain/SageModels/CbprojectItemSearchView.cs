using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class CbprojectItemSearchView
    {
        public long PcprojectItemId { get; set; }
        public string ProjectCode { get; set; } = null!;
        public string ProjectTitle { get; set; } = null!;
        public string Code { get; set; } = null!;
        public string Title { get; set; } = null!;
    }
}

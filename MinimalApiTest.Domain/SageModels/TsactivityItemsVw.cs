using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class TsactivityItemsVw
    {
        public string Code { get; set; } = null!;
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public long PcprojectItemId { get; set; }
        public long? PccostItemId { get; set; }
        public long? ParentProjectId { get; set; }
        public long PcintegrationOptionId { get; set; }
        public bool IntegrationEnabled { get; set; }
    }
}

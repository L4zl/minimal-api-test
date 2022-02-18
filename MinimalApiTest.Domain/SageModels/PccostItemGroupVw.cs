using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PccostItemGroupVw
    {
        public long PccostItemGroupId { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int IsCostItem { get; set; }
    }
}

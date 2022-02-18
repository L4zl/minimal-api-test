using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconHmitemsView
    {
        public long ItemId { get; set; }
        public string? ItemCode { get; set; }
        public string? Description { get; set; }
        public string ItemType { get; set; } = null!;
    }
}

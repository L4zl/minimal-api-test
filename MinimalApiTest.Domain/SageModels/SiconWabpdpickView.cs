using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconWabpdpickView
    {
        public long PdpickId { get; set; }
        public string PickNumber { get; set; } = null!;
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; } = null!;
        public int PickStatus { get; set; }
        public DateTime? StatusChangedAt { get; set; }
        public string StatusChangedBy { get; set; } = null!;
    }
}

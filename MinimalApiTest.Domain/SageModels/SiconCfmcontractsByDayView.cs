using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconCfmcontractsByDayView
    {
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public long SlcustomerAccountId { get; set; }
        public DateTime? DueDate { get; set; }
        public decimal? Value { get; set; }
    }
}

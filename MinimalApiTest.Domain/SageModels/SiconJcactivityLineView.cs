using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconJcactivityLineView
    {
        public long Id { get; set; }
        public long? SiJcJobId { get; set; }
        public long? SiJobActivityId { get; set; }
        public string LineType { get; set; } = null!;
        public string? Description { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public decimal? Cost { get; set; }
        public decimal? Revenue { get; set; }
        public decimal? Pccomplete { get; set; }
    }
}
